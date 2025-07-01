::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### InSideRadius {#insideradius style="tab-stops: 0pt"}

 

Sets / Gets the radius of the doughnut hole of Pie chart as a fraction of the radius of the pie.

[]{style="FONT-SIZE: 8pt"} 

::: {align="center"}
+-------------------------------------+-------------------------------------+
|                                                                           |
|                                                                           |
| **Details**                                                               |
+-------------------------------------+-------------------------------------+
| **Possible Values**                 | Ranges from 0.0f to 1.0f.           |
+-------------------------------------+-------------------------------------+
| **Default Value    **               | **None.**                           |
+-------------------------------------+-------------------------------------+
| **2D / 3D Limitations**             | No.                                 |
+-------------------------------------+-------------------------------------+
| **Applies to Chart Element**        | All series.                         |
+-------------------------------------+-------------------------------------+
| **Applies to Chart Types**          | Pie Chart.                          |
+-------------------------------------+-------------------------------------+
:::

 

Here is some sample code.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                 |
|                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                       |
|                                                                                                                                                                                                                |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ series1 = [this]{style="COLOR: blue"}.chartControl1.Model.NewSeries([\"Market\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                |
| [series1.InSideRadius = 0.5f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                  |
|                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series1 [As]{style="COLOR: blue"} ChartSeries = [Me]{style="COLOR: blue"}.chartControl1.Model.NewSeries([\"Market\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                           |
| [series1.InSideRadius = 0.5f]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_152.jpg){border="0"}

 

Figure 152: InSideRadius Pie Chart

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

See Also

 

[Pie Chart]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p117} 

[]{#related-topics}
::::
