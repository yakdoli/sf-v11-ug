::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ErrorBarsSymbolShape {#errorbarssymbolshape style="tab-stops: 0pt"}

[]{style="FONT-SIZE: 8pt"} 

This property determines the shape of the error bar symbol when [DrawErrorBars]{.UGHyperlink} is **true**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-------------------------------------+--------------------------------------------------------------------+
|                                                                                                          |
|                                                                                                          |
| Details                                                                                                  |
+-------------------------------------+--------------------------------------------------------------------+
| Possible Values                     | None - No marker will be shown.\                                   |
|                                     | Line - A Line will be drawn as the marker.\                        |
|                                     | Square - A Square will be drawn as the marker.\                    |
|                                     | Circle - A Circle will be drawn as the marker.\                    |
|                                     | Diamond - A Diamond will be drawn as the marker.\                  |
|                                     | Triangle - A Triangle will be drawn as the marker.                 |
|                                     |                                                                    |
|                                     | VertLine - A VerticalLine will be drawn as the marker.             |
|                                     |                                                                    |
|                                     | Cross - A Cross will be drawn as the marker.                       |
|                                     |                                                                    |
|                                     | Hexagon - An Hexagon will be drawn as the marker.                  |
|                                     |                                                                    |
|                                     | Horizline - An Horizontal Line will be drawn as the marker.        |
|                                     |                                                                    |
|                                     | Image - An Image will be drawn as the marker.                      |
|                                     |                                                                    |
|                                     | InvertedTriangle - A InvertedTriangle will be drawn as the marker. |
|                                     |                                                                    |
|                                     | Pentagon - A Pentagon will be drawn as the marker.                 |
|                                     |                                                                    |
|                                     | Star - A Star will be drawn as the marker.                         |
+-------------------------------------+--------------------------------------------------------------------+
| Default Value                       | Diamond                                                            |
+-------------------------------------+--------------------------------------------------------------------+
| 2D / 3D Limitations                 | No                                                                 |
+-------------------------------------+--------------------------------------------------------------------+
| Applies to Chart Element            | All Series                                                         |
+-------------------------------------+--------------------------------------------------------------------+
| Applies to Chart Types              | Line Chart                                                         |
+-------------------------------------+--------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Here is some sample code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [this.]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartWebControl1.Series\[0\].DrawErrorBars =[ true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].ErrorBarsSymbolShape = [ChartSymbolShape]{style="COLOR: teal"}.Circle;]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(0).DrawErrorBars = [true]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(0).ErrorBarsSymbolShape = [ChartSymbolShape]{style="COLOR: teal"}.Circle]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

![](ImagesExt/image64_125.jpg){border="0"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Figure 119: Line Chart with ErrorBarSymbol set to \"Circle\"

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}** 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[Line Chart]{.UGHyperlink}[, ]{.UGHyperlink}[DrawErrorBars]{.UGHyperlink}[]{.UGHyperlink}

[]{#p99} 

[]{#related-topics}
::::
