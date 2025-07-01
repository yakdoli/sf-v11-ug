::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### SmartLabels {#smartlabels style="tab-stops: 0pt"}

 

Specifies the behavior of the labels. If set to true, the labels will be rendered to avoid overlap with other labels.

 

::: {align="center"}
+-------------------------------------+--------------------------------------------------------------------------+
|                                                                                                                |
|                                                                                                                |
| **Details**                                                                                                    |
+-------------------------------------+--------------------------------------------------------------------------+
| **Possible Values**                 | [·      ]{style="FONT-FAMILY: Symbol"}**True**  -  Enables smart labels  |
|                                     |                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**False** -  Disables smart labels |
+-------------------------------------+--------------------------------------------------------------------------+
| **Default Value    **               | **False**                                                                |
+-------------------------------------+--------------------------------------------------------------------------+
| **2D / 3D Limitations**             | No                                                                       |
+-------------------------------------+--------------------------------------------------------------------------+
| **Applies to Chart Element**        | Any Series                                                               |
+-------------------------------------+--------------------------------------------------------------------------+
| **Applies to Chart Types**          | All chart types                                                          |
+-------------------------------------+--------------------------------------------------------------------------+
:::

 

Here is sample code snippet using Smart Labels in ColumnChart.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.DisplayText = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [series.Styles\[0\].Text = series.Name;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].SmartLabels = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                              |
|                                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                        |
|                                                                                                                                                                                                                 |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.DisplayText = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                                 |
| [series.Styles(0).Text = series.Name]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                 |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).SmartLabels = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**                                            **

![](ImagesExt/image84_204.jpg){border="0"}

 

Figure 204: Chart without enabling SmartLabels

 

![](ImagesExt/image84_205.jpg){border="0"}

 

Figure 205: Smart Label Enabled Column Chart

 

Custom borders for smart Labels

 

Smart labels can be made more smarter by displaying with customized borders. The color and the width of the border can be changed using the appearance properties available. **SmartLabelsBorderColor** property is used to set color for the border and **SmartLabelsBorderWidth** property is used to set the width of the border.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.[Series\[0\].SmartLabelsBorderColor = ]{style="COLOR: black"}[Color]{style="COLOR: blue"}[.Yellow;]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.[Series\[0\].SmartLabelsBorderWidth = 2]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                               |
|                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                         |
|                                                                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.[Series(0).SmartLabelsBorderColor = ]{style="COLOR: black"}[Color]{style="COLOR: blue"}[.Yellow]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                  |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.[Series(0).SmartLabelsBorderWidth = 2]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

See Also

 

[Chart Types]{.UGHyperlink}[]{.UGHyperlink}

[]{#p150} 

 

[]{#related-topics}
::::
