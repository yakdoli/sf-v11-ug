::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### DisplayShadow {#displayshadow style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Specifies if the shadow should be displayed for the series.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+--------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Details                                                                                                                                                                                                                                                                                                                                                                                                                        |
+--------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Possible Values          | True, False                                                                                                                                                                                                                                                                                                                                                                                         |
+--------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Default Value            | False                                                                                                                                                                                                                                                                                                                                                                                               |
+--------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| 2D / 3D Limitations      | Only 2D                                                                                                                                                                                                                                                                                                                                                                                             |
+--------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Element | All series and points                                                                                                                                                                                                                                                                                                                                                                               |
+--------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Types   | Area Chart, Bar Chart, Bubble Chart, Column Chart, Stacking Column Chart, Stacking Column100 Chart, Line Chart, Spline Chart, Rotated Spline chart, Stepline Chart, Candle Chart, Kagi Chart, Point and Figure Chart, Renko Chart, Threeline Break Charts, Gantt Chart, Histogram chart, Tornado Chart, Combination Chart, Box and Whisker Chart, Pie Chart, Polar And Radar Chart, Step Area Chart |
+--------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Here is some sample code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Series wide setting

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                      |
|                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].Style.DisplayShadow = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [//To display shadow for specific data points use Styles\[\]]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                               |
|                                                                                                                                                                               |
| [series1.Styles\[0\].DisplayShadow = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                          |
| [Me.]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartWebControl1.Series(0).Style.DisplayShadow =[ True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                      |
|                                                                                                                                                                          |
| [\'To display shadow for specific data points use Styles\[\]]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                          |
|                                                                                                                                                                          |
| [series1.Styles(0).DisplayShadow = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

![](ImagesExt/image64_114.jpg){border="0"}

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

Figure 108: Line Chart with Shadow Series

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

Specific Data Point Setting

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                      |
|                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                            |
|                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].Styles\[0\].DisplayShadow = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].Styles\[1\].DisplayShadow = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                           |
|                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                              |
| [Me.]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartWebControl1.Series(0).Styles(0).DisplayShadow =[ True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                              |
| [Me.]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartWebControl1.Series(0).Styles(1).DisplayShadow =[ True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[[Pyramid Chart]{.UGHyperlink}](ms-xhelp:///?Id=87f1bae2-020f-4860-bfbc-7e1d60c45078)[, ]{.UGHyperlink}[[Funnel Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Area Charts]{.UGHyperlink}](ms-xhelp:///?Id=f6d7bb1e-6e5a-4165-9dda-eab8aceb7e4d)[, ]{.UGHyperlink}[[Bar Charts]{.UGHyperlink}](ms-xhelp:///?Id=f561904f-bd17-40a3-a1b6-498ed5d46c43)[, ]{.UGHyperlink}[[Bubble Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Column Charts]{.UGHyperlink}](ms-xhelp:///?Id=f6d7bb1e-6e5a-4165-9dda-eab8aceb7e4d)[, ]{.UGHyperlink}[[Candle Chart]{.UGHyperlink}](ms-xhelp:///?Id=f561904f-bd17-40a3-a1b6-498ed5d46c43)[, ]{.UGHyperlink}[[Renko chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Three Line Break Chart]{.UGHyperlink}](ms-xhelp:///?Id=f6d7bb1e-6e5a-4165-9dda-eab8aceb7e4d)[, ]{.UGHyperlink}[[Box and Whisker Chart]{.UGHyperlink}](ms-xhelp:///?Id=f561904f-bd17-40a3-a1b6-498ed5d46c43)[, ]{.UGHyperlink}[[Gantt Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Histogram Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Tornado Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Polar and Radar Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Pie Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Funnel Chart]{.UGHyperlink}](ms-xhelp:///?Id=f6d7bb1e-6e5a-4165-9dda-eab8aceb7e4d)[, ]{.UGHyperlink}[[Area Charts]{.UGHyperlink}](ms-xhelp:///?Id=f561904f-bd17-40a3-a1b6-498ed5d46c43)[, ]{.UGHyperlink}[[Column Charts]{.UGHyperlink}](ms-xhelp:///?Id=87f1bae2-020f-4860-bfbc-7e1d60c45078)[, ]{.UGHyperlink}[Candle Chart]{.UGHyperlink}[ ]{.UGHyperlink}

[]{#p89} 

 

[]{#related-topics}
::::
