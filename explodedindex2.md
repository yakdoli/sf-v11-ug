::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ExplodedIndex {#explodedindex style="tab-stops: 0pt"}

 

Gets / sets the Index point that is to be used when a point is to be exploded from the main display.

 

::: {align="center"}
+-------------------------------------+--------------------------------------------------------------+
|                                                                                                    |
|                                                                                                    |
| Details                                                                                            |
+-------------------------------------+--------------------------------------------------------------+
| **Possible Values**                 | An integer indicating the index of the slice to be exploded. |
+-------------------------------------+--------------------------------------------------------------+
| **Default Value    **               | **-1**                                                       |
+-------------------------------------+--------------------------------------------------------------+
| **2D / 3D Limitations**             | No                                                           |
+-------------------------------------+--------------------------------------------------------------+
| **Applies to Chart Element**        | All series                                                   |
+-------------------------------------+--------------------------------------------------------------+
| **Applies to Chart Types**          | Pie Chart, Doughnut Chart                                    |
+-------------------------------------+--------------------------------------------------------------+
:::

 

Here is some sample code.

 

+--------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                             |
|                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                            |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].ExplodedIndex = 0;]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                    |
|                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                       |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).ExplodedIndex = 0]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_127.jpg){border="0"}

 

Figure 126: Pie Chart with Exploded Index

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

See Also

 

[Doughnut Chart]{.UGHyperlink}[,]{style="COLOR: blue"}[ ]{.UGHyperlink}[Pie Chart]{.UGHyperlink}[]{style="COLOR: black"}

 

[]{#p100} 

[]{#related-topics}
::::
