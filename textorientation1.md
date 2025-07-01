::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### TextOrientation {#textorientation style="tab-stops: 0pt"}

 

It is used to align the text of the series within the data point region.

 

::: {align="center"}
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                |
|                                                                                                                                                                |
| Details                                                                                                                                                        |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Possible Values**                 | [·      ]{style="FONT-FAMILY: Symbol"}**Center** - Aligns to the center of the point.                                    |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Down** - Aligns below the point.                                                 |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Left** - Aligns to the left position to the point.                               |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**RegionCenter** - Aligns below the region that represents the points.             |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**RegionDown** - Aligns below the region that represents the points.               |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**RegionUp** - Aligns to the top of the region that represents the points.         |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Right** - Aligns to the right of the point.                                      |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Smart** - Aligns in a manner that is appropriate to the situation.               |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**SymbolCenter** - Text is centered to the symbol that is associated to the point. |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**Up** - Aligns to the top of the point.                                           |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**UpLeft** - Aligns to the top left corner of the point.                           |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**UpRight** - Aligns to the top right corner of the point.                         |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Default Value    **               | **Up**                                                                                                                   |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **2D / 3D Limitations**             | No                                                                                                                       |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Element**        | Any Series                                                                                                               |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Types**          | All chart types                                                                                                          |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
:::

 

Here is some sample code.

 

Series Wide Setting

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                       |
| [// Text Orientation of chart series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].Style.TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.RegionDown;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Up;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}         |
|                                                                                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Blue;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                              |
|                                                                                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].Style.TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Red;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                          |
| [\' Text Orientation of chart series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                          |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).Style.TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.RegionDown]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                          |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Up]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}         |
|                                                                                                                                                                                                                                                                                                          |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Blue]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                              |
|                                                                                                                                                                                                                                                                                                          |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).Style.TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Red]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_222.jpg){border="0"}

 

Figure 222: Text Orientation set for the Chart Series

 

Specific Data Point Setting

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

Text orientation for specific data points can be set using **Series.Style\[i\].TextOrientation** property, where \"i\" represents the index of data points ranging from 0 to n.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].Styles\[0\].TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.RegionDown;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Styles\[0\].TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Up;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}         |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Styles\[0\].TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Blue;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                              |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].Styles\[0\].TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Red;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                               |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].Styles\[1\].TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Smart;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}      |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Styles\[1\].TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.UpRight;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}    |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Styles\[1\].TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Green;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                             |
|                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].Styles\[1\].TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Yellow;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).Styles(0).TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.RegionDown]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Styles(0).TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Up]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}         |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Styles(0).TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Blue]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                              |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).Styles(0).TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Red]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                               |
|                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).Styles(1).TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Smart]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}      |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Styles(1).TextOrientation = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartTextOrientation]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.UpRight]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}    |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Styles(1).TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Green]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                             |
|                                                                                                                                                                                                                                                                                                              |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).Styles(1).TextColor=]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Yellow]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

See Also

[[]{style="COLOR: blue"}]{.UGHyperlink}

[[Chart Types]{style="COLOR: blue"}]{.UGHyperlink}

 

[]{#p162} 

 

[]{#related-topics}
::::
