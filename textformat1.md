::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### TextFormat {#textformat style="tab-stops: 0pt"}

 

Sets the format that is to be applied to values that are displayed as text

 

::: {align="center"}
+------------------------------+----------------------------------------------------------------+
| Details                                                                                       |
+------------------------------+----------------------------------------------------------------+
| **Possible Values**          | Any string value with \'{0}\' as place holder for the Y value. |
+------------------------------+----------------------------------------------------------------+
| **Default Value    **        | **Nil**                                                        |
+------------------------------+----------------------------------------------------------------+
| **2D / 3D Limitations**      | No                                                             |
+------------------------------+----------------------------------------------------------------+
| **Applies to Chart Element** | Any Series and Points                                          |
+------------------------------+----------------------------------------------------------------+
| **Applies to Chart Types**   | All Chart Types                                                |
+------------------------------+----------------------------------------------------------------+
:::

 

Here is sample code snippet using TextFormat in Column Chart.

 

Series wide setting

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.TextFormat = \"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[T = {0}]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\";]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.TextFormat = \"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[T = {0}]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

![](ImagesExt/image84_220.jpg){border="0"}

 

Figure 220: TextFormat = \"T = {0}\"

 

Specific Data Point Setting

 

TextFormats for individual data points are specified using below code.

 

+----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                         |
|                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                               |
|                                                                                                                                        |
| [chartControl1.Series\[0\].Styles\[0\].TextFormat = [\"YValue : {0}\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                        |
| [chartControl1.Series\[0\].Styles\[1\].TextFormat = [\"Dollars : {0:C}\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                |
|                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                          |
|                                                                                                                                   |
| [chartControl1.Series(0).Styles(0).TextFormat = [\"YValue : {0}\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                   |
| [chartControl1.Series(0).Styles(1).TextFormat = [\"Dollars : {0:C}\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

See Also

 

[]{style="COLOR: black"}

[[Chart Types]{style="COLOR: blue"}]{.UGHyperlink}

 

[]{#p160} 

 

[]{#related-topics}
::::
