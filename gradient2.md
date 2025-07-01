::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Gradient {#gradient style="tab-stops: 0pt"}

 

Gets / sets ColorBlend for a pie item. ColorBlend defines arrays of colors and positions used for interpolating color blending in a multicolor gradient.

 

::: {align="center"}
+-------------------------------------+-------------------------------------+
|                                                                           |
|                                                                           |
| Details                                                                   |
+-------------------------------------+-------------------------------------+
| **Possible Values**                 | A ColorBlend object                 |
+-------------------------------------+-------------------------------------+
| **Default Value    **               | **None**                            |
+-------------------------------------+-------------------------------------+
| **2D / 3D Limitations**             | No                                  |
+-------------------------------------+-------------------------------------+
| **Applies to Chart Element**        | All series                          |
+-------------------------------------+-------------------------------------+
| **Applies to Chart Types**          | Pie Chart                           |
+-------------------------------------+-------------------------------------+
:::

 

Here is some sample code.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                     |
| [series.ConfigItems.PieItem.PieType = [ChartPieType]{style="COLOR: teal"}.Custom;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                     |
| [ColorBlend]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ clrblnd = [new]{style="COLOR: blue"} [ColorBlend]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                                                     |
| [clrblnd.Positions = [new]{style="COLOR: blue"} [float]{style="COLOR: blue"}\[\] { 0f, 0.05f, 1f };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                     |
| [clrblnd.Colors = [new]{style="COLOR: blue"} [Color]{style="COLOR: teal"}\[\] { [Color]{style="COLOR: teal"}.SteelBlue, [Color]{style="COLOR: teal"}.LightSteelBlue, [Color]{style="COLOR: teal"}.AliceBlue };]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                     |
| [// Specifying Gradient Style ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                     |
| [series.ConfigItems.PieItem.Gradient = clrblnd;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [series.ConfigItems.PieItem.PieType = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartPieType]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Custom]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ clrblnd As ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ColorBlend]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ColorBlend]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [clrblnd.Positions = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New Single]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[() { 0f, 0.05f, 1f }]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [clrblnd.Colors = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[() { ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[SteelBlue[, ]{style="COLOR: black"}[Color]{style="COLOR: teal"}[.]{style="COLOR: black"}LightSteelBlue[, ]{style="COLOR: black"}[Color]{style="COLOR: teal"}[.]{style="COLOR: black"}AliceBlue[ }]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [\' Specifying Gradient Style ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [series.ConfigItems.PieItem.Gradient = clrblnd]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

![](ImagesExt/image84_143.jpg){border="0"}

 

Figure 142: Pie Chart with Gradient Styles Set

 

See Also

 

[Pie Chart]{.UGHyperlink}[]{.UGHyperlink}

[]{#p109} 

 

[]{#related-topics}
::::
