::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### TextOffset {#textoffset style="tab-stops: 0pt"}

 

Sets the Offset of the text from the position of the chart point.

 

::: {align="center"}
+------------------------------+-----------------+
| **Details**                                    |
+------------------------------+-----------------+
| **Possible Values**          | Any float value |
+------------------------------+-----------------+
| **Default Value    **        | **2.5**         |
+------------------------------+-----------------+
| **2D / 3D Limitations**      | No              |
+------------------------------+-----------------+
| **Applies to Chart Element** | Any Series      |
+------------------------------+-----------------+
| **Applies to Chart Types**   | All Chart Types |
+------------------------------+-----------------+
:::

 

Here is a sample code snippet using TextOffset in Column Chart.

 

Series Wide Setting

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                  |
|                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                             |
|                                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.TextOffset = 10.0F;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                         |
|                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                   |
|                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.TextOffset = 10.0F]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

![](ImagesExt/image84_221.jpg){border="0"}

 

Figure 221: Text Offset set to 10.0F

 

Specific Data Point Setting

 

TextOffset for data points can be specified using **Series.Styles\[0\].TextOffset** property.

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                        |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                   |
|                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Styles\[0\].TextOffset = 10.0F;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Styles\[1\].TextOffset = 15.0F;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                             |
|                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Styles(0).TextOffset = 10.0F]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Styles(1).TextOffset = 15.0F]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

 

See Also

[]{style="COLOR: black"}

[Chart Types]{.MsoHyperlink}[]{style="COLOR: black"}

 

[]{#p161} 

 

[]{#related-topics}
::::
