::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Border {#border style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The user can also set the Border color and Border style for the chart series.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+--------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Details                                                                                                                                                                                                                                 |
+--------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Possible Values          | Any Color, Width, Style for the Borders                                                                                                                                                                      |
+--------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Default Value            | Color is  Black, Width value is 1, DashStyle is Solid                                                                                                                                                        |
+--------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| 2D / 3D Limitations      | No                                                                                                                                                                                                           |
+--------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Element | All series and points                                                                                                                                                                                        |
+--------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Types   | Pyramid, Funnel, Area, Bar, Bubble, Column Chart, Candle Chart, Renko chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Histogram Chart, Tornado Chart, Polar and Radar Chart and Pie Chart |
+--------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

The line type can be configured using the **ChartSeries.Style.Border** property as in the following example.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]                    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                        |
|                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                  |
|                                                                                                                                                                                                                                           |
| [// Set the border style required for the column chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                                                           |
| [series.Style.Border.Width = 3;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                        |
|                                                                                                                                                                                                                                           |
| [series.Style.Border.Color = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[White;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [// Set the Series style]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                               |
|                                                                                                                                                                                                                                           |
| [series.Style.DisplayShadow = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                                           |
| [series.Style.ShadowInterior = [new]{style="COLOR: blue"} Syncfusion.Drawing.[BrushInfo]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                           |
| [series.Style.ShadowOffset = [new]{style="COLOR: blue"} [Size]{style="COLOR: teal"}(3, 3);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\' Set the border style required for the column chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [series.Style.Border.Width = 3]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [series.Style.Border.Color = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[White]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\' Set the Series style]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [series.Style.DisplayShadow = True]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [series.Style.ShadowInterior = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ Syncfusion.Drawing.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[BrushInfo]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[White[)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [series.Style.ShadowOffset = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ Size(3, 3)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

![](ImagesExt/image64_100.jpg){border="0"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Figure 95: Border Lined Column Chart

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

To apply this on specific data points:

[]{style="FONT-FAMILY: 'Courier New'; COLOR: red; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------+
| **[\[C#\]                    ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                           |
|                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                     |
|                                                                                                              |
| [//Sets border for the 1st point in 1st series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}            |
|                                                                                                              |
| [series1.Styles\[0\].Border.Width = 3;]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                              |
| [series1.Styles\[0\].Border.Color = [Color]{style="COLOR: teal"}.White;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                              |
| [//Sets border for the 3rd point in 2nd series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}            |
|                                                                                                              |
| [series2.Styles\[2\].Border.Width = 3;]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                              |
| [series2.Styles\[2\].Border.Color = [Color]{style="COLOR: teal"}.White;]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                |
|                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                          |
|                                                                                                   |
| [\'Sets border for the 1st point in 1st series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                   |
| [series1.Styles(0).Border.Width = 3]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                   |
| [series1.Styles(0).Border.Color = Color.White]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                   |
| [\'Sets border for the 3rd point in 2nd series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                   |
| [series2.Styles(2).Border.Width = 3]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                   |
| [series2.Styles(2).Border.Color = Color.White]{style="FONT-FAMILY: 'Courier New'"}                |
+---------------------------------------------------------------------------------------------------+

[]{style="COLOR: black; FONT-SIZE: 8pt"} 

![](ImagesExt/image64_101.jpg){border="0"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Figure 96: Individual Data Points with White Border

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[[Pyramid Chart]{.UGHyperlink}](ms-xhelp:///?Id=b9bb35af-2ea5-41f4-9e01-afc481e6ad26)[, ]{.UGHyperlink}[[Funnel Chart]{.UGHyperlink}](ms-xhelp:///?Id=b9bb35af-2ea5-41f4-9e01-afc481e6ad26)[, ]{.UGHyperlink}[[Area Charts]{.UGHyperlink}](ms-xhelp:///?Id=3eb7eb94-5332-4941-affa-4bfbabf22ff3)[, ]{.UGHyperlink}[[Bar Charts]{.UGHyperlink}](ms-xhelp:///?Id=3bb86204-e7ec-4a61-bdca-9e283ca3108d)[, ]{.UGHyperlink}[[Bubble Chart]{.UGHyperlink}](ms-xhelp:///?Id=3bb86204-e7ec-4a61-bdca-9e283ca3108d)[, ]{.UGHyperlink}[[Column Charts]{.UGHyperlink}](ms-xhelp:///?Id=143afae1-3f83-4d32-9bfa-92ed7022a696)[, ]{.UGHyperlink}[[Candle Chart]{.UGHyperlink}](ms-xhelp:///?Id=4ea7b22a-855a-4bc0-987c-1c2eed094b4f)[, ]{.UGHyperlink}[[Renko chart]{.UGHyperlink}](ms-xhelp:///?Id=198c3293-53b1-49ad-b12d-53568388c9d7)[, ]{.UGHyperlink}[[Three Line Break Chart]{.UGHyperlink}](ms-xhelp:///?Id=3bb86204-e7ec-4a61-bdca-9e283ca3108d)[, ]{.UGHyperlink}[[Box and Whisker Chart]{.UGHyperlink}](ms-xhelp:///?Id=143afae1-3f83-4d32-9bfa-92ed7022a696)[, ]{.UGHyperlink}[[Gantt Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Histogram Chart]{.UGHyperlink}](ms-xhelp:///?Id=f6d7bb1e-6e5a-4165-9dda-eab8aceb7e4d)[, ]{.UGHyperlink}[[Tornado Chart]{.UGHyperlink}](ms-xhelp:///?Id=f561904f-bd17-40a3-a1b6-498ed5d46c43)[, ]{.UGHyperlink}[[Polar and Radar Chart]{.UGHyperlink}](ms-xhelp:///?Id=07dff027-c96d-450f-9a9b-6037f838f4da)[, ]{.UGHyperlink}[[Pie Chart]{.UGHyperlink}](ms-xhelp:///?Id=f6d7bb1e-6e5a-4165-9dda-eab8aceb7e4d)[]{.UGHyperlink}

[]{#p81} 

[]{#related-topics}
::::
