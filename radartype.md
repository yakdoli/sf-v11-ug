::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Radar Type {#radar-type style="tab-stops: 0pt"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Indicates the type of radar chart to be rendered.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-------------------------------------+----------------------------------------------------------------------------------------------------------+
| Details                                                                                                                                        |
+-------------------------------------+----------------------------------------------------------------------------------------------------------+
| Possible Values                     | Area - Renders the radar chart such that the points are connected and the enclosed region is not filled. |
|                                     |                                                                                                          |
|                                     | Line - Renders the radar chart such that the points are connected but the enclosed region is not filled. |
|                                     |                                                                                                          |
|                                     | Symbol - Points are rendered with the associated symbols                                                 |
+-------------------------------------+----------------------------------------------------------------------------------------------------------+
| Default Value                       | Area                                                                                                     |
+-------------------------------------+----------------------------------------------------------------------------------------------------------+
| 2D / 3D Limitations                 | No                                                                                                       |
+-------------------------------------+----------------------------------------------------------------------------------------------------------+
| Applies to Chart Element            | Any series                                                                                               |
+-------------------------------------+----------------------------------------------------------------------------------------------------------+
| Applies to Chart Types              | Polar and Radar Chart                                                                                    |
+-------------------------------------+----------------------------------------------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Here is code snippet using RadarType.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].ConfigItems.RadarItem.Type = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartRadarDrawType]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Symbol;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[1\].ConfigItems.RadarItem.Type = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartRadarDrawType]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Symbol;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].Style.Symbol.Shape = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartSymbolShape]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Star;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}             |
|                                                                                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[1\].Style.Symbol.Shape = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartSymbolShape]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Star;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}             |
|                                                                                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].Style.Symbol.Color =]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Blue;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                        |
|                                                                                                                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[1\].Style.Symbol.Color = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Green;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                            |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(0).ConfigItems.RadarItem.Type = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartRadarDrawType]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Symbol]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                            |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(1).ConfigItems.RadarItem.Type = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartRadarDrawType]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Symbol]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                            |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(0).Style.Symbol.Shape = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartSymbolShape]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Star]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}             |
|                                                                                                                                                                                                                                                                                                            |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(1).Style.Symbol.Shape =]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ ChartSymbolShape]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Star]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}             |
|                                                                                                                                                                                                                                                                                                            |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(0).Style.Symbol.Color = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Blue]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                        |
|                                                                                                                                                                                                                                                                                                            |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(1).Style.Symbol.Color =]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Green]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

![](ImagesExt/image64_181.jpg){border="0"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Figure 175: Radar Chart

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[Polar and Radar Charts]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p137} 

[]{#related-topics}
::::
