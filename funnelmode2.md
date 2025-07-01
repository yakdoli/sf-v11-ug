::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### FunnelMode {#funnelmode style="tab-stops: 0pt"}

 

Gets or sets the chart funnel mode.

 

::: {align="center"}
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                          |
|                                                                                                                                                          |
| Details                                                                                                                                                  |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------+
|                                     |                                                                                                                    |
|                                     |                                                                                                                    |
| **Possible Values**                 | [·      ]{style="FONT-FAMILY: Symbol"}**YIsWidth** - DataPoint y-value controls the radius of the funnel segment.  |
|                                     |                                                                                                                    |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**YIsHeight** - DataPoint y-value controls the height of the funnel segment. |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------+
|                                     |                                                                                                                    |
|                                     |                                                                                                                    |
| **Default Value    **               | **YIsHeight**                                                                                                      |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------+
|                                     |                                                                                                                    |
|                                     |                                                                                                                    |
| **2D / 3D Limitations**             | No                                                                                                                 |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------+
|                                     |                                                                                                                    |
|                                     |                                                                                                                    |
| **Applies to Chart Element**        | All series                                                                                                         |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------+
|                                     |                                                                                                                    |
|                                     |                                                                                                                    |
| **Applies to Chart Types**          | Funnel Chart                                                                                                       |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------+
:::

 

Here is some sample code.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].ConfigItems.FunnelItem.FunnelMode = ChartFunnelMode.YIsHeight;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].ConfigItems.FunnelItem.FunnelMode = ChartFunnelMode.YIsWidth;]{style="FONT-FAMILY: 'Courier New'"}  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                          |
|                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).ConfigItems.FunnelItem.FunnelMode = ChartFunnelMode.YIsHeight]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).ConfigItems.FunnelItem.FunnelMode = ChartFunnelMode.YIsWidth]{style="FONT-FAMILY: 'Courier New'"}  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_136.jpg){border="0"}

 

Figure 135: Funnel Chart with FunnelMode as \"Height\"

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

![](ImagesExt/image84_137.jpg){border="0"}

 

Figure 136: Funnel Chart with FunnelMode as \"Width\"

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

See Also

 

[Funnel Chart]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#p105} 

[]{#related-topics}
::::
