::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ElementBorders {#elementborders style="tab-stops: 0pt"}

 

Gets / sets the border settings for elements associated with the chart point. You can specify the inner and outer border. It is currently used only by symbols rendered by the ChartPoint (inherited from ChartStyleInfo).

 

::: {align="center"}
+-------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                       |
| Details                                                                                                                                                                                                                               |
+-------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Possible Values**                 | Border setting object                                                                                                                                                                           |
+-------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Default Value    **               | [·      ]{style="FONT-FAMILY: Symbol"}**Weight** -- Thin                                                                                                                                        |
|                                     |                                                                                                                                                                                                 |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Width value** -- 1                                                                                                                                      |
|                                     |                                                                                                                                                                                                 |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Style** - Standard                                                                                                                                      |
+-------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **2D / 3D Limitations**             | No                                                                                                                                                                                              |
+-------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Element**        | All series and points                                                                                                                                                                           |
+-------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Types**          | Area Charts, Bar Charts, Bubble Chart, Column Charts, Line  Charts, Candle Chart, Renko chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Tornado Chart, Polar and Radar Chart |
+-------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Here is some sample code.

 

Series Wide Setting

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                         |
|                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                               |
|                                                                                                                                                                                                        |
| [// Setting Symbol for the ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.Symbol.Color = [Color]{style="COLOR: teal"}.Yellow;]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.Symbol.Shape = [ChartSymbolShape]{style="COLOR: teal"}.InvertedTriangle;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [// Setting ElementBorder for a symbol]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                        |
| [ChartBordersInfo]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ cbi = [new]{style="COLOR: blue"} [ChartBordersInfo]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                        |
| [cbi.Outer = [new]{style="COLOR: blue"} [ChartBorder]{style="COLOR: teal"}([ChartBorderStyle]{style="COLOR: teal"}.Solid, [Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                        |
| [cbi.Inner = [new]{style="COLOR: blue"} [ChartBorder]{style="COLOR: teal"}([ChartBorderStyle]{style="COLOR: teal"}.DashDot, [Color]{style="COLOR: teal"}.Cyan);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.ElementBorders = cbi;]{style="FONT-FAMILY: 'Courier New'"}                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [ \' Setting Symbol for the ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                        |
|                                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.Symbol.Color = [Color]{style="COLOR: teal"}.Yellow]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.Symbol.Shape = [ChartSymbolShape]{style="COLOR: teal"}.InvertedTriangle]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [ \' Setting ElementBorder for a symbol]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                        |
|                                                                                                                                                                                                   |
| [cbi As [ChartBordersInfo]{style="COLOR: teal"} = New [ChartBordersInfo]{style="COLOR: teal"}()]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                   |
| [cbi.Outer = [New]{style="COLOR: blue"} [ChartBorder]{style="COLOR: teal"}([ChartBorderStyle]{style="COLOR: teal"}.Solid, Color.White)]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                   |
| [cbi.Inner = [New]{style="COLOR: blue"} ChartBorder(ChartBorderStyle.DashDot, Color.Cyan)]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.ElementBorders = cbi]{style="FONT-FAMILY: 'Courier New'"}                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_122.jpg){border="0"}

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

Figure 121: Column Chart with ElementBorder

 

Specific Data Point Setting

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                              |
|                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                             |
| [//Specifying element border for the first data point Styles(0), second data point Styles(1) and so on..]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Styles\[0\].ElementBorders = cbi;]{style="FONT-FAMILY: 'Courier New'"}   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                          |
|                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                             |
| [\'Specifying element border for the first data point Styles(0), second data point Styles(1) and so on..]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Styles(0).ElementBorders = cbi]{style="FONT-FAMILY: 'Courier New'"}        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

See Also

 

[Area Charts]{.UGHyperlink},[ ]{.UGHyperlink}[Bar Charts]{.UGHyperlink}, [Bubble Chart]{.UGHyperlink}, [Column Charts]{.UGHyperlink}, [Line Charts]{.UGHyperlink}, [Candle Chart]{.UGHyperlink}, [Renko chart]{.UGHyperlink}, [Three Line Break Chart]{.UGHyperlink},

[Box and Whisker Chart]{.UGHyperlink}, [Gantt Chart]{.UGHyperlink}, [Tornado Chart]{.UGHyperlink}, [Polar and Radar Chart]{.UGHyperlink}[]{style="COLOR: black"}

 

[]{#p95} 

[]{#related-topics}
::::
