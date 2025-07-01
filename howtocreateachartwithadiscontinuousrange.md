::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=bc97b4a0-6ec2-4fb4-bdb2-dd1c9dbb3431){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=74622424-8698-4a81-9ebb-383b3f66263f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=702d1cd4-b827-4e46-83f2-e25d649fc6e6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Advanced](ms-xhelp:///?Id=bc97b4a0-6ec2-4fb4-bdb2-dd1c9dbb3431){.d2h_breadcrumbsNormal}
:::

### How to create a Chart with a discontinuous range? {#how-to-create-a-chart-with-a-discontinuous-range style="tab-stops: 0pt"}

 

The following code example illustrates creating a chart with discontiguous data ranges.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                 |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                             |
|                                                                                                                                                  |
| [// Entering the data for the chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                          |
|                                                                                                                                                  |
| [sheet.Range\[[\"A1\"]{style="COLOR: maroon"}\].Text = [\"Texas books Unit sales\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                  |
| [sheet.Range\[[\"A1:D1\"]{style="COLOR: maroon"}\].Merge();]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                  |
| [sheet.Range\[[\"A1\"]{style="COLOR: maroon"}\].CellStyle.Font.Bold = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [sheet.Range\[[\"B2\"]{style="COLOR: maroon"}\].Text = [\"Jan\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                  |
| [sheet.Range\[[\"C2\"]{style="COLOR: maroon"}\].Text = [\"Feb\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                  |
| [sheet.Range\[[\"D2\"]{style="COLOR: maroon"}\].Text = [\"Mar\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [sheet.Range\[[\"A3\"]{style="COLOR: maroon"}\].Text = [\"Austin\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                  |
| [sheet.Range\[[\"A4\"]{style="COLOR: maroon"}\].Text = [\"Dallas\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                  |
| [sheet.Range\[[\"A5\"]{style="COLOR: maroon"}\].Text = [\"Houston\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                  |
| [sheet.Range\[[\"A6\"]{style="COLOR: maroon"}\].Text = [\"San Antonio\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [sheet.Range\[[\"B3\"]{style="COLOR: maroon"}\].Number = 53.75;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"B4\"]{style="COLOR: maroon"}\].Number = 52.85;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"B5\"]{style="COLOR: maroon"}\].Number = 59.77;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"B6\"]{style="COLOR: maroon"}\].Number = 96.15;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [sheet.Range\[[\"C3\"]{style="COLOR: maroon"}\].Number = 79.79;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"C4\"]{style="COLOR: maroon"}\].Number = 59.22;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"C5\"]{style="COLOR: maroon"}\].Number = 10.09;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"C6\"]{style="COLOR: maroon"}\].Number = 73.02;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [sheet.Range\[[\"D3\"]{style="COLOR: maroon"}\].Number = 26.72;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"D4\"]{style="COLOR: maroon"}\].Number = 33.71;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"D5\"]{style="COLOR: maroon"}\].Number = 45.81;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"D6\"]{style="COLOR: maroon"}\].Number = 12.17;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [sheet.Range\[[\"F1\"]{style="COLOR: maroon"}\].Number = 26.72;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"F2\"]{style="COLOR: maroon"}\].Number = 33.71;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [sheet.Range\[[\"F3\"]{style="COLOR: maroon"}\].Number = 45.81;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| [sheet.Range\[[\"F4\"]{style="COLOR: maroon"}\].Number = 12.17;]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [// Discontiguous range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                      |
|                                                                                                                                                  |
| [IRanges]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ rangesOne = sheet.CreateRangesCollection();]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                  |
| [rangesOne.Add(sheet.Range\[[\"B3:B6\"]{style="COLOR: maroon"}\]);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                  |
| [rangesOne.Add(sheet.Range\[[\"F1:F2\"]{style="COLOR: maroon"}\]);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [IRanges]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ rangesTwo = sheet.CreateRangesCollection();]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                  |
| [rangesTwo.Add(sheet.Range\[[\"D3:D6\"]{style="COLOR: maroon"}\]);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                  |
| [rangesTwo.Add(sheet.Range\[[\"F3:F4\"]{style="COLOR: maroon"}\]);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [// Adding a New (Embedded chart)to the Worksheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                                                  |
| [IChartShape]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ shape = sheet.Charts.Add();]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                  |
| [shape.PrimaryCategoryAxis.Title = [\"City\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                  |
| [shape.PrimaryValueAxis.Title = [\"Sales (in Dollars)\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                  |
| [shape.ChartTitle = [\"Texas Books Unit Sales\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [// Setting the Series Names in a Legend.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                     |
|                                                                                                                                                  |
| [IChartSerie]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ serieOne = shape.Series.Add();]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                  |
| [serieOne.Name = [\"Jan\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                  |
| [serieOne.Values = rangesOne;]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [IChartSerie]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ serietwo = shape.Series.Add();]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                  |
| [serietwo.Name = [\"March\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                  |
| [serietwo.Values = rangesTwo;]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [// Setting the(Rows & Columns)Property for the Embedded chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                               |
|                                                                                                                                                  |
| [shape.BottomRow = 40;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                  |
| [shape.TopRow = 10;]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                  |
| [shape.LeftColumn = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                  |
| [shape.RightColumn = 15;]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                       |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [\' Entering the data for the chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                            |
| [sheet.Range([\"A1\"]{style="COLOR: maroon"}).Text = [\"Texas books Unit sales\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                            |
| [sheet.Range([\"A1:D1\"]{style="COLOR: maroon"}).Merge()]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                            |
| [sheet.Range([\"A1\"]{style="COLOR: maroon"}).CellStyle.Font.Bold = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [sheet.Range([\"B2\"]{style="COLOR: maroon"}).Text = [\"Jan\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                            |
| [sheet.Range([\"C2\"]{style="COLOR: maroon"}).Text = [\"Feb\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                            |
| [sheet.Range([\"D2\"]{style="COLOR: maroon"}).Text = [\"Mar\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                      |
|                                                                                                                                                                                            |
| [sheet.Range([\"A3\"]{style="COLOR: maroon"}).Text = [\"Austin\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                            |
| [sheet.Range([\"A4\"]{style="COLOR: maroon"}).Text = [\"Dallas\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                            |
| [sheet.Range([\"A5\"]{style="COLOR: maroon"}).Text = [\"Houston\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                            |
| [sheet.Range([\"A6\"]{style="COLOR: maroon"}).Text = [\"San Antonio\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                      |
|                                                                                                                                                                                            |
| [sheet.Range([\"B3\"]{style="COLOR: maroon"}).Number = 53.75]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"B4\"]{style="COLOR: maroon"}).Number = 52.85]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"B5\"]{style="COLOR: maroon"}).Number = 59.77]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"B6\"]{style="COLOR: maroon"}).Number = 96.15]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [sheet.Range([\"C3\"]{style="COLOR: maroon"}).Number = 79.79]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"C4\"]{style="COLOR: maroon"}).Number = 59.22]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"C5\"]{style="COLOR: maroon"}).Number = 10.09]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"C6\"]{style="COLOR: maroon"}).Number = 73.02]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [sheet.Range([\"D3\"]{style="COLOR: maroon"}).Number = 26.72]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"D4\"]{style="COLOR: maroon"}).Number = 33.71]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"D5\"]{style="COLOR: maroon"}).Number = 45.81]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"D6\"]{style="COLOR: maroon"}).Number = 12.17]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [sheet.Range([\"F1\"]{style="COLOR: maroon"}).Number = 26.72]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"F2\"]{style="COLOR: maroon"}).Number = 33.71]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [sheet.Range([\"F3\"]{style="COLOR: maroon"}).Number = 45.81]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| [sheet.Range([\"F4\"]{style="COLOR: maroon"}).Number = 12.17]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [\' Discontiguous range.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                |
|                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rangesOne [As]{style="COLOR: blue"} Syncfusion.XlsIO.IRanges = sheet.CreateRangesCollection()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [rangesOne.Add(sheet.Range([\"B3:B6\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                            |
| [rangesOne.Add(sheet.Range([\"F1:F2\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rangesTwo [As]{style="COLOR: blue"} Syncfusion.XlsIO.IRanges = sheet.CreateRangesCollection()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [rangesTwo.Add(sheet.Range([\"D3:D6\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                            |
| [rangesTwo.Add(sheet.Range([\"F3:F4\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [\' Adding a New(Embedded chart)to the Worksheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ shape [As]{style="COLOR: blue"} Syncfusion.XlsIO.IChartShape = sheet.Charts.Add()]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                            |
| [shape.PrimaryCategoryAxis.Title = [\"City\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                            |
| [shape.PrimaryValueAxis.Title = [\"Sales (in Dollars)\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                            |
| [shape.ChartTitle = [\"Texas Books Unit Sales\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                      |
|                                                                                                                                                                                            |
| [\' Setting the Series Names in a Legend.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ serieOne [As]{style="COLOR: blue"} Syncfusion.XlsIO.IChartSerie = shape.Series.Add()]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                            |
| [serieOne.Name = [\"Jan\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                            |
| [serieOne.Values = rangesOne]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ serietwo [As]{style="COLOR: blue"} Syncfusion.XlsIO.IChartSerie = shape.Series.Add()]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                            |
| [serietwo.Name = [\"March\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                            |
| [serietwo.Values = rangesTwo]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                            |
| [\' Setting the (Rows & Columns)Property for the Embedded chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                        |
|                                                                                                                                                                                            |
| [shape.BottomRow = 40]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                            |
| [shape.TopRow = 10]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                            |
| [shape.LeftColumn = 3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                            |
| [shape.RightColumn = 15]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
