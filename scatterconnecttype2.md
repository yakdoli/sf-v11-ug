::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ScatterConnectType {#scatterconnecttype style="tab-stops: 0pt"}

 

Specifies the connection type of the Scatter Charts.

 

::: {align="center"}
+-------------------------------------+-----------------------------------------------+
|                                                                                     |
|                                                                                     |
| **Details**                                                                         |
+-------------------------------------+-----------------------------------------------+
| **Possible Values**                 | None - Scatter Connect Type will be none.     |
|                                     |                                               |
|                                     | Line - Scatter Connect Type will be Line.     |
|                                     |                                               |
|                                     | Spline - Scatter Connect Type will be spline. |
+-------------------------------------+-----------------------------------------------+
| **Default Value    **               | **None**                                      |
+-------------------------------------+-----------------------------------------------+
| **2D / 3D Limitations**             | No                                            |
+-------------------------------------+-----------------------------------------------+
| **Applies to Chart Element**        | All series                                    |
+-------------------------------------+-----------------------------------------------+
| **Applies to Chart Types**          | Scatter Chart                                 |
+-------------------------------------+-----------------------------------------------+
:::

 

**Scatter Line Chart**

 

Optionally, you can connect the points in the series through straight lines using the **ScatterConnectType** property as shown below.

 

+-------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                    |
|                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                          |
|                                                                                                                   |
| [series.ScatterConnectType = [ScatterConnectType]{style="COLOR: teal"}.Line;]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                               |
|                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                         |
|                                                                                                                  |
| [series.ScatterConnectType = [ScatterConnectType]{style="COLOR: teal"}.Line]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_189.jpg){border="0"}

 

Figure 189: Scatter Line Chart

 

Scatter Spline Chart

 

Alternatively, you can connect the points in the series through splines using the **ScatterConnectType** property as shown below.

 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                      |
|                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                            |
|                                                                                                                     |
| [series.ScatterConnectType = [ScatterConnectType]{style="COLOR: teal"}.Spline;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                     |
| [series.ScatterSplineTension = 1; [// Default is 0]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}      |
+---------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                 |
|                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                           |
|                                                                                                                    |
| [series.ScatterConnectType = [ScatterConnectType]{style="COLOR: teal"}.Spline]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                    |
| [series.ScatterSplineTension = 1 \'[ Default is 0]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}      |
+--------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_190.jpg){border="0"}

 

Figure 190: Scatter Spline Chart

 

See Also

 

[Scatter Chart]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p141} 

 

[]{#related-topics}
::::
