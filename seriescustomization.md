::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=73a501f1-be34-4a0b-a30e-272d8cf8bfc9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=008536df-64ab-481a-83d6-537934bbb4a6){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=100687ce-82f2-4424-9d16-0949ea76cf15){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart Series](ms-xhelp:///?Id=73a501f1-be34-4a0b-a30e-272d8cf8bfc9){.d2h_breadcrumbsNormal}
:::

### Series Customization {#series-customization style="tab-stops: 0pt"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'"}** 

Essential Chart offers numerous appearance and behavior customization capabilities at the series level and on individual points.

Some of these options are applicable only for the whole series while the rest could be applied on the specific data points. Similarly some of these options are specific to certain chart types.

Note that styles set at the series level automatically propagate to the points in the series.

Interestingly the Chart control lets the user to edit the styles of a series by double clicking on it during run-time. This feature can be turned on by setting the **AllowUserEditStyles** property to **true**.

The table below lists the customization options available in **ChartSeries** and their restrictions.

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

::: {align="center"}
  Customization Option                                                                                                      Applies to Series or DataPoints\*   Applies to Chart Type
  ------------------------------------------------------------------------------------------------------------------------- ----------------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [[AngleOffset]{.UGHyperlink}](ms-xhelp:///?Id=6b56643e-3900-459b-89d1-deb1ab797ee9)[]{.UGHyperlink}                       Series                              Pie Chart
  [[Border]{.UGHyperlink}](ms-xhelp:///?Id=6afee5e9-a791-44c5-a81c-f9993abfec26)[]{.UGHyperlink}                            Series and points                   Pyramid, Funnel, Area, Bar, Bubble, Column Chart, Candle Chart, Renko chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Histogram Chart, Tornado Chart, Polar and Radar Chart and Pie Chart.
  [[BubbleType]{.UGHyperlink}](ms-xhelp:///?Id=1c15afa7-8953-4462-878b-324a0a416a00)[]{.UGHyperlink}                        Series                              Bubble chart.
  [[ColumnDrawMode]{.UGHyperlink}](ms-xhelp:///?Id=34f1a463-01f7-4e65-8b4b-c0c0ba6c8c72)[]{.UGHyperlink}                                                        Column Chart, ColumnRange Chart,Bar Chart, BoxAndWhisker Chart, Gantt Chart.
  [[ColumnWidthMode]{.UGHyperlink}](ms-xhelp:///?Id=d5e34a18-f843-4851-9899-4e9b9abf0f0b)[]{.UGHyperlink}                   Series                              Column charts
  [[ColumnFixedWidth]{.UGHyperlink}](ms-xhelp:///?Id=a03436c9-4d1c-47e4-b9f8-61037120c937)[]{.UGHyperlink}                  Series                              Column charts
  [[ColumnType]{.UGHyperlink}](ms-xhelp:///?Id=bc1bfc57-10a0-448a-be7b-9d519415426f)[]{.UGHyperlink}                        Series                              Column
  [[ColorsMode]{.UGHyperlink}](ms-xhelp:///?Id=1c15afa7-8953-4462-878b-324a0a416a00)[]{.UGHyperlink}                        Series                              Renko chart.
  [[DarkLightPower]{.UGHyperlink}](ms-xhelp:///?Id=bd9183d3-c075-49d2-994e-41791c69af8f)[]{.UGHyperlink}                    Series                              Renko chart.
  [[DisplayShadow]{.UGHyperlink}](ms-xhelp:///?Id=4513f314-952c-4586-979c-e49651f9f983)[]{.UGHyperlink}                     Series and points                   Area Chart, Bar Chart, Bubble Chart, Column Chart, Stacking Column Chart, Stacking Column100 Chart, Line Chart, Spline Chart, Rotated Spline chart, Stepline Chart, Candle Chart, Kagi Chart, Point and Figure Chart, Renko Chart, Threeline Break Charts, Gantt Chart, Histogram chart, Tornado Chart, Combination Chart, Box and Whisker Chart.
  [[DisplayText]{.UGHyperlink}](ms-xhelp:///?Id=f55792d4-92f5-4ddb-b2f0-dc7ae8a6f220)[]{.UGHyperlink}                       Series and points                   All Chart types.
  [[DoughnutCoeficient]{.UGHyperlink}](ms-xhelp:///?Id=6afee5e9-a791-44c5-a81c-f9993abfec26)[]{.UGHyperlink}                Series                              Pie Chart.
  [[DrawColumnSeparatingLines]{.UGHyperlink}](ms-xhelp:///?Id=087d2329-deef-41b1-b218-8800f4adcc6a)[]{.UGHyperlink}         Series                              Column Chart.
  [[DrawErrorBars]{.UGHyperlink}](ms-xhelp:///?Id=91ab6769-147c-4321-9d48-0db3357ed43d)[]{.UGHyperlink}                     Series                              Column Chart, Line Chart and HiLo Chart.
  [[DrawHistogramNormalDistribution]{.UGHyperlink}](ms-xhelp:///?Id=6b56643e-3900-459b-89d1-deb1ab797ee9)[]{.UGHyperlink}   Series                              Histogram chart.
  [[DrawSeriesNameInDepth]{.UGHyperlink}](ms-xhelp:///?Id=dd8debe0-4838-438c-88ce-3c90b61c3365)[]{.UGHyperlink}             Series                              All Chart types.
  [[ElementBorders]{.UGHyperlink}](ms-xhelp:///?Id=34f1a463-01f7-4e65-8b4b-c0c0ba6c8c72)[]{.UGHyperlink}                    Series and points                   Area Charts, Bar Charts, Bubble Chart, Column Charts, Line  Charts, Candle Chart, Renko chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Tornado Chart, Polar and Radar Chart.
  [[EnablePhongStyle]{.UGHyperlink}](ms-xhelp:///?Id=d5e34a18-f843-4851-9899-4e9b9abf0f0b)[]{.UGHyperlink}                  Series                              Bubble Chart.
  [[ErrorBarsSymbolShape]{.UGHyperlink}](ms-xhelp:///?Id=a03436c9-4d1c-47e4-b9f8-61037120c937)[]{.UGHyperlink}              Series                              Column Chart, Line Chart and HiLo Chart.
  [[ExplodedAll]{.UGHyperlink}](ms-xhelp:///?Id=bc1bfc57-10a0-448a-be7b-9d519415426f)[]{.UGHyperlink}                       Series                              Pie Chart, Doughnut Chart.
  [[ExplodedIndex]{.UGHyperlink}](ms-xhelp:///?Id=1c15afa7-8953-4462-878b-324a0a416a00)[]{.UGHyperlink}                     Series                              Pie Chart.
  [[ExplosionOffset]{.UGHyperlink}](ms-xhelp:///?Id=bd9183d3-c075-49d2-994e-41791c69af8f)[]{.UGHyperlink}                   Series                              Pie Chart.
  [[FancyToolTip]{.UGHyperlink}](ms-xhelp:///?Id=4513f314-952c-4586-979c-e49651f9f983)[]{.UGHyperlink}                      Series                              All Chart Types.
  [[FigureBase]{.UGHyperlink}](ms-xhelp:///?Id=f55792d4-92f5-4ddb-b2f0-dc7ae8a6f220)[]{.UGHyperlink}                        Series                              Funnel and Pyramid chart.
  [[FillMode]{.UGHyperlink}](ms-xhelp:///?Id=6afee5e9-a791-44c5-a81c-f9993abfec26)[]{.UGHyperlink}                          Series                              Pie Chart
  [[FunnelMode]{.UGHyperlink}](ms-xhelp:///?Id=087d2329-deef-41b1-b218-8800f4adcc6a)[]{.UGHyperlink}                        Series                              Funnel and Pyramid chart.
  [[Font]{.UGHyperlink}](ms-xhelp:///?Id=91ab6769-147c-4321-9d48-0db3357ed43d)[]{.UGHyperlink}                              Series and points                   All Chart types.
  [[GanttDrawMode]{.UGHyperlink}](ms-xhelp:///?Id=6b56643e-3900-459b-89d1-deb1ab797ee9)[]{.UGHyperlink}                     Series                              Gantt Chart.
  [[GapRatio]{.UGHyperlink}](ms-xhelp:///?Id=dd8debe0-4838-438c-88ce-3c90b61c3365)[]{.UGHyperlink}                          Series                              Funnel and Pyramid chart.
  [[Gradient]{.UGHyperlink}](ms-xhelp:///?Id=34f1a463-01f7-4e65-8b4b-c0c0ba6c8c72)[]{.UGHyperlink}                          Series                              Pie Chart.
  [[HeightBox]{.UGHyperlink}](ms-xhelp:///?Id=d5e34a18-f843-4851-9899-4e9b9abf0f0b)[]{.UGHyperlink}                         Series                              Point And Figure Chart.
  [[HeightByAreaDepth]{.UGHyperlink}](ms-xhelp:///?Id=a03436c9-4d1c-47e4-b9f8-61037120c937)[]{.UGHyperlink}                 Series                              Pie Chart.
  [[HeightCoeficient]{.UGHyperlink}](ms-xhelp:///?Id=bc1bfc57-10a0-448a-be7b-9d519415426f)[]{.UGHyperlink}                  Series                              Pie Chart.
  [[HighlightInterior]{.UGHyperlink}](ms-xhelp:///?Id=e2ccfc7e-65d6-4d37-b63a-4d82606af0e4)[]{.UGHyperlink}                 Series                              Bar Charts, Pie, Funnel, Pyramid,Bubble, Column, Area, Stacking Area, Stacking Area100, Line Charts, Box and Whisker, Gantt Chart and Tornado Chart.
  [[HitTestRadius]{.UGHyperlink}](ms-xhelp:///?Id=9b3f1132-dff2-4620-8e0e-c79012593ef1)[]{.UGHyperlink}                     Series                              Line Chart and Step Line Chart.
  [[ImageIndex]{.UGHyperlink}](ms-xhelp:///?Id=800d1402-5911-4002-ad2f-88f57bb560ee)[]{.UGHyperlink}                        Series and points                   Area Charts, Bar Charts, Bubble Chart, Column Charts, Line  Charts, Candle Chart, Renko chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Tornado Chart, Polar and Radar Chart.
  [[Images]{.UGHyperlink}](ms-xhelp:///?Id=52d6bd7e-03d8-4bb6-a473-cb1f701965cf)[]{.UGHyperlink}                            Series and points                   Area Charts, Bar Charts, Bubble Chart, Column Charts, Line  Charts, Candle Chart, Renko chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Tornado Chart, Polar and Radar Chart.
  [[InSideRadius]{.UGHyperlink}](ms-xhelp:///?Id=c4165bbc-0f6a-4125-9d83-0831dd093f2d)[]{.UGHyperlink}                      Series                              Pie Chart.
  [[Interior]{.UGHyperlink}](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8)[]{.UGHyperlink}                          Series and points                   All Chart Types.
  [[LabelPlacement]{.UGHyperlink}](ms-xhelp:///?Id=57fb2f9f-ea9c-4b11-b8fe-1b1f2a32af12)[]{.UGHyperlink}                    Series                              Funnel and Pyramid Charts.
  [[LabelStyle]{.UGHyperlink}](ms-xhelp:///?Id=800d1402-5911-4002-ad2f-88f57bb560ee)[]{.UGHyperlink}                        Series                              Funnel and Pyramid, Pie
  [[LegendItem]{.UGHyperlink}](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8)[]{.UGHyperlink}                        Series                              All Chart Types.
  [[LightAngle]{.UGHyperlink}](ms-xhelp:///?Id=77b3e3a6-fde2-466f-88a9-1e93c7e1ed7c)[]{.UGHyperlink}                        Series                              Scatter Chart, Column Charts , Bar Charts, Box and Whisker Chart, Gantt Chart, Histogram Chart, Tornado Chart, Polar and Radar Chart.
  [[LightColor]{.UGHyperlink}](ms-xhelp:///?Id=84271f20-7a83-45dd-adfc-dfd5519ca11d)[]{.UGHyperlink}                        Series                              Scatter Chart, Column Charts , Bar Charts, Box and Whisker Chart, Gantt Chart, Histogram Chart, Tornado Chart, Polar and Radar Chart.
  [[Name]{.UGHyperlink}](ms-xhelp:///?Id=77b3e3a6-fde2-466f-88a9-1e93c7e1ed7c)[]{.UGHyperlink}                              Series                              All chart types.
  [[NumberOfHistogramIntervals]{.UGHyperlink}](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8)[]{.UGHyperlink}        Series                              Histogram Chart.
  [[OpenCloseDrawMode]{.UGHyperlink}](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8)[]{.UGHyperlink}                 Series                              HiLo OpenClose chart.
  [[OptimizePiePointPositions]{.UGHyperlink}](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8)[]{.UGHyperlink}         Series                              Pie chart
  [[PhongAlpha]{.UGHyperlink}](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8)[]{.UGHyperlink}                        Series                              Column Chart.
  [[PieType]{.UGHyperlink}](ms-xhelp:///?Id=ea758680-939d-4d65-8abe-8c3be198af29)[]{.UGHyperlink}                           Series                              Pie chart
  [[PieWithSameRadius]{.UGHyperlink}](ms-xhelp:///?Id=c1c71db5-9e60-4a81-b1cd-59b55729717b)[]{.UGHyperlink}                 Series                              Pie chart and Doughnut chart.
  [[PointsToolTipFormat]{.UGHyperlink}](ms-xhelp:///?Id=671ffe8b-e89f-46e0-b0b6-2c5e56888ea6)[]{.UGHyperlink}               Series                              All Chart Types.
  [[PointWidth]{.UGHyperlink}](ms-xhelp:///?Id=3f2133fa-ed50-405b-a66b-86e487f15622)[]{.UGHyperlink}                        Series and points                   Gantt Chart.
  [[PriceDownColor]{.UGHyperlink}](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8)[]{.UGHyperlink}                    Series                              Financial types
  [[PriceUpColor]{.UGHyperlink}](ms-xhelp:///?Id=41939395-c927-4e81-b042-23129c45aa91)[]{.UGHyperlink}                      Series                              Financial types
  [[PyramidMode]{.UGHyperlink}](ms-xhelp:///?Id=0ca81653-ba35-4377-971e-9f2c707a43b5)[]{.UGHyperlink}                       Series                              Pyramid
  [[Radar Type]{.UGHyperlink}](ms-xhelp:///?Id=af94879f-4d6b-42be-b304-6a157c6ce6e8)[]{.UGHyperlink}                        Series                              Polar and Radar Chart.
  [[RadarStyle]{.UGHyperlink}](ms-xhelp:///?Id=e991c962-4733-4932-ad5c-3e27db8c5be1)[]{.UGHyperlink}                        Series                              Polar and Radar Chart.
  [[RelatedPoints]{.UGHyperlink}](ms-xhelp:///?Id=8789f2c5-74a0-4e88-8a0a-a78adb57dddd)[]{.UGHyperlink}                     Series and points                   Gantt Chart.
  [[ReversalAmount]{.UGHyperlink}](ms-xhelp:///?Id=fec527b4-81df-475a-8337-f0210487c595)[]{.UGHyperlink}                    Series                              Kagi, PointAndFigure, Renko
  [[Rotate]{.UGHyperlink}](ms-xhelp:///?Id=015b2e12-67e9-455e-81f4-e71de2e77f13)[]{.UGHyperlink}                            Series                              Column Charts, Bar Charts, Area charts, Line Chart, Spline Chart, Stepline Chart, Candle Chart, HiLo Chart, HiLo Open Chart, Kagi Chart, BoxandWhisker chart, Histogram chart, Polar and Radar Chart.
  [[ScatterConnectType]{.UGHyperlink}](ms-xhelp:///?Id=756c2018-0d89-433a-a557-91f6d69d93d0)[]{.UGHyperlink}                Series                              Scatter Chart.
  [[ScatterSplineTension]{.UGHyperlink}](ms-xhelp:///?Id=4db2878d-ce3e-48ba-bf59-4b005da8a972)[]{.UGHyperlink}              Series                              Scatter Chart.
  [[SeriesToolTipFormat]{.UGHyperlink}](ms-xhelp:///?Id=f92f9d4e-63bc-47be-95f1-c82f269cc059)[]{.UGHyperlink}               Series                              Area Charts.
  [[ShadingMode]{.UGHyperlink}](ms-xhelp:///?Id=1aaca817-67d6-4364-973a-d22aadf96f84)[]{.UGHyperlink}                       Series                              Column Chart, BarCharts, Candle Chart, HiLO Chart, HiLoOpenClose Chart, Tornado chart, BoxandWhisker chart, Gantt Chart, Histogram Chart, Polar and Radar Chart.
  [[ShadowInterior]{.UGHyperlink}](ms-xhelp:///?Id=1aaca817-67d6-4364-973a-d22aadf96f84)[]{.UGHyperlink}                    Series and points                   Column Charts, Bubble Chart, Line Charts, BarCharts, Candle Chart, Kagi Chart, Point and Figure Chart, Renko Chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Histogram Chart, Tornado Chart, Pie Chart, Polar and Radar Chart.
  [[ShadowOffset]{.UGHyperlink}](ms-xhelp:///?Id=8789f2c5-74a0-4e88-8a0a-a78adb57dddd)[]{.UGHyperlink}                      Series and points                   Column Charts, Bubble Chart, Line Charts, BarCharts, Candle Chart, Kagi Chart, Point and Figure Chart, Renko Chart, Three Line Break Chart, Box and Whisker Chart, Gantt Chart, Histogram Chart, Tornado Chart, Pie Chart, Polar and Radar Chart.
  [[ShowDataBindLabels]{.UGHyperlink}](ms-xhelp:///?Id=8789f2c5-74a0-4e88-8a0a-a78adb57dddd)[]{.UGHyperlink}                Series                              Pie Chart, Doughnut Chart, Funnel and Pyramid charts.
  [[ShowHistogramDataPoints]{.UGHyperlink}](ms-xhelp:///?Id=8789f2c5-74a0-4e88-8a0a-a78adb57dddd)[]{.UGHyperlink}           Series                              Histogram Chart
  [[ShowTicks]{.UGHyperlink}](ms-xhelp:///?Id=fe48602f-3c69-4742-b232-c7702b229061)[]{.UGHyperlink}                         Series                              Pie Chart.
  [[SmartLabels]{.UGHyperlink}](ms-xhelp:///?Id=fe48602f-3c69-4742-b232-c7702b229061)[]{.UGHyperlink}                       Series                              All Chart Types.
  [[Spacing]{.UGHyperlink}](ms-xhelp:///?Id=d25416bf-85e8-49f5-b439-42bc7285796a)[]{.UGHyperlink}                           Series and Points.                  Column Charts, BarCharts, Box and Whisker Chart, Gantt Chart, Tornado Chart.
  [[Spacing Between Series]{.UGHyperlink}](ms-xhelp:///?Id=f603ce3b-4542-460d-9a52-e9ea62929e4f)[]{.UGHyperlink}            Series                              Area Charts, BarCharts, Line Charts, Bubble Chart, Financial Charts, Gantt Chart, Histogram chart, Tornado Chart, Combination Chart, Box and Whisker Chart.
  [[SpacingBetweenPoints]{.UGHyperlink}](ms-xhelp:///?Id=3063a1c9-6970-4454-821a-5c5e19506018)[]{.UGHyperlink}              Series Points                       Column Chart, Bar Chart, HiLo Chart, HiLo Open Close Chart, Candle Chart, Tornado Chart, Boxes and Whisker Chart.
  [[StepItem.Inverted]{.UGHyperlink}](ms-xhelp:///?Id=f603ce3b-4542-460d-9a52-e9ea62929e4f)[]{.UGHyperlink}                 Series                              StepAreaChart, StepLine Chart.
  [[Summary]{.UGHyperlink}](ms-xhelp:///?Id=3063a1c9-6970-4454-821a-5c5e19506018)[]{.UGHyperlink}                           Series                              All Chart Types.
  [[Symbol]{.UGHyperlink}](ms-xhelp:///?Id=3063a1c9-6970-4454-821a-5c5e19506018)[]{.UGHyperlink}                            Series and points                   Column Chart, Bar Chart, Bubble Chart, Financial Chart, Line Chart, BoxandWhisker Chart, Gantt chart, Tornado chart, Radar Chart
  [[Text (Series)]{.UGHyperlink}](ms-xhelp:///?Id=3063a1c9-6970-4454-821a-5c5e19506018)[]{.UGHyperlink}                     Series                              All Chart Types.
  [[Text (Style)]{.UGHyperlink}](ms-xhelp:///?Id=3063a1c9-6970-4454-821a-5c5e19506018)[]{.UGHyperlink}                      Series and Points                   All Chart Types.
  [[TextColor]{.UGHyperlink}](ms-xhelp:///?Id=ced93159-6f25-40b2-aef6-a1ca3381e342)[]{.UGHyperlink}                         Series and points                   All Chart Types.
  [[TextFormat]{.UGHyperlink}](ms-xhelp:///?Id=ced93159-6f25-40b2-aef6-a1ca3381e342)[]{.UGHyperlink}                        Series and points                   All Chart Types.
  [[TextOffset]{.UGHyperlink}](ms-xhelp:///?Id=f7a16816-b3f6-4532-b8b0-3188cb905f4d)[]{.UGHyperlink}                        Series and points                   All Chart Types.
  [[TextOrientation]{.UGHyperlink}](ms-xhelp:///?Id=f7a16816-b3f6-4532-b8b0-3188cb905f4d)[]{.UGHyperlink}                   Series and points                   All Chart Types.
  [[ToolTip]{.UGHyperlink}](ms-xhelp:///?Id=7f4791ca-2cc8-4cb9-aabc-c8104eb002ac)[]{.UGHyperlink}                           Series and points                   Scatter Chart.
  [[ToolTipFormat]{.UGHyperlink}](ms-xhelp:///?Id=4f9d3e4e-2802-44be-87ed-4dcbdd1ba4ec)[]{.UGHyperlink}                     Series and points                   Scatter Chart.
  [[Visible]{.UGHyperlink}](ms-xhelp:///?Id=7f4791ca-2cc8-4cb9-aabc-c8104eb002ac)[]{.UGHyperlink}                           Series                              All Chart Types.
  [[VisibleAllPies]{.UGHyperlink}](ms-xhelp:///?Id=e51b8fab-552d-4c64-90e1-88c3c22bf0b6)[]{.UGHyperlink}                    Series                              Pie Chart.
  [[XType]{.UGHyperlink}](ms-xhelp:///?Id=8e84a1fd-2caa-498d-80a8-8db22895c27b)[]{.UGHyperlink}                             Series                              All Chart Types.
  [[YType]{.UGHyperlink}](ms-xhelp:///?Id=8e84a1fd-2caa-498d-80a8-8db22895c27b)[]{.UGHyperlink}                             Series                              All Chart Types.
  [[ZOrder]{.UGHyperlink}](ms-xhelp:///?Id=7be0cc3e-239f-44db-9c07-5f5ed873d123)[]{.UGHyperlink}                            Series                              Gantt chart, StackingBar chart, StackingBar100 chart, StackingColumn chart, StackedColumn100 chart, StackingArea chart, StackingArea100 chart.
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

\* Indicates whether the property affects ALL the points in the series or if the property can be set on individual points as well.

[]{#p79} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}AngleOffset](ms-xhelp:///?Id=63cb808a-0e9a-4b2c-9e20-c36cf17fa7db){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Border](ms-xhelp:///?Id=a9d7fc16-2f47-4c45-9fa7-76a276f590f7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}BubbleType](ms-xhelp:///?Id=52a2ef92-e795-48cb-8ebc-6a8b8da18e2f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ColumnDrawMode](ms-xhelp:///?Id=fee7f4ad-afc0-4b1f-a5d1-061316ce3a3a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ColumnWidthMode](ms-xhelp:///?Id=25bc2e9a-a3f7-4424-9e79-7e1da74ebe52){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ColumnFixedWidth](ms-xhelp:///?Id=4a6423a2-9dd3-4b01-a1e7-d9f08e467ef3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ColumnType](ms-xhelp:///?Id=f6edb227-dc5f-4d77-a521-172dd9d62941){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ColorsMode](ms-xhelp:///?Id=7733c330-51b5-43da-a163-aa9a72cc42bd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DarkLightPower](ms-xhelp:///?Id=72a4b858-c241-47ca-be51-29cecacc0a6d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DisplayShadow](ms-xhelp:///?Id=ccdead70-c427-4c4d-b2b8-ee3748344316){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DisplayText](ms-xhelp:///?Id=19a6ff55-3cb6-4638-b720-c537084d06c5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DoughnutCoeficient](ms-xhelp:///?Id=93597293-90f5-4a48-8bc1-5fedb5bb3178){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DrawColumnSeparatingLines](ms-xhelp:///?Id=709e71c2-2db4-49f6-bc60-0d7a978cde10){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DrawErrorBars](ms-xhelp:///?Id=f37fd355-ebf0-4c18-8052-8e894b95e0c9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DrawHistogramNormalDistribution](ms-xhelp:///?Id=79f324ff-1ee8-42b9-9e2b-66acb9d9c357){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DrawSeriesNameInDepth](ms-xhelp:///?Id=ca2fcb23-9c73-4679-a85c-81703c20c2d9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DropSeriesPoints](ms-xhelp:///?Id=c5917ec6-42dc-4036-badf-91102b667c54){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ElementBorders](ms-xhelp:///?Id=190c377b-34ae-4e47-9b08-5c39becb01f6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}EnablePhongStyle](ms-xhelp:///?Id=c1bae0b8-10e6-4043-8c55-6cba94c42098){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ErrorBarsSymbolShape](ms-xhelp:///?Id=30eb3a72-47b9-49e3-a6a0-61cf87488629){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ExplodedAll](ms-xhelp:///?Id=c159fb1f-fa0b-453c-a76b-333186dab8a4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ExplodedIndex](ms-xhelp:///?Id=3f6edd62-659e-4e6c-9bcd-6ac72d8c3afe){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ExplosionOffset](ms-xhelp:///?Id=5482e560-2b2c-4627-b8a5-5b68d212f270){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}FancyToolTip](ms-xhelp:///?Id=1582c240-5ad9-44b9-8d2c-84f30e3153b0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}FigureBase](ms-xhelp:///?Id=1856b06e-85c3-4f08-99fd-3168bc8212ae){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}FillMode](ms-xhelp:///?Id=00f3f397-994e-435a-a48d-94549ccd4998){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}FunnelMode](ms-xhelp:///?Id=29481b8a-e955-4e14-8d8f-7622681ded45){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Font](ms-xhelp:///?Id=fbfa87cc-b660-4ea9-b509-731256896bdc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}GanttDrawMode](ms-xhelp:///?Id=bcaa0a08-35c4-49e0-a647-e8106b75e7e4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}GapRatio](ms-xhelp:///?Id=1126b735-44c9-41ba-bc8f-7c54c0f68d33){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Gradient](ms-xhelp:///?Id=20798d7d-ca78-4d42-8f23-c4e0525d6e06){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HeightBox](ms-xhelp:///?Id=9301c0a2-e2f6-4e92-8411-a8fda97904ca){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HeightByAreaDepth](ms-xhelp:///?Id=a0489b5b-33ea-4450-a73c-d3fe8338800e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HeightCoeficient](ms-xhelp:///?Id=5636c5ac-4cb4-408b-a444-b23a7eda13b0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HighlightInterior](ms-xhelp:///?Id=b31ed3eb-3eb9-4d64-985b-58e09a8ddcb1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}HitTestRadius](ms-xhelp:///?Id=5a767c44-8c3e-47d1-861e-f6918eca9296){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ImageIndex](ms-xhelp:///?Id=e6ee4505-4785-4ffa-baeb-e4587e7320b8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Images](ms-xhelp:///?Id=6b6ca5f9-a611-43e7-8f2e-39df47b72c72){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}InSideRadius](ms-xhelp:///?Id=3eb9d71f-d9ef-4465-bd0f-ce358005b8b0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Interior](ms-xhelp:///?Id=59a90133-448b-495e-9bb2-a183bf784ce3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}LabelPlacement](ms-xhelp:///?Id=f9603510-4730-4d49-8874-96c3f1d7982e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}LabelStyle](ms-xhelp:///?Id=307fc852-9600-41b9-9bad-9c96e05e2f13){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}LegendItem](ms-xhelp:///?Id=11015953-00d7-4589-8a02-68309339e326){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}LightAngle](ms-xhelp:///?Id=b33341d4-d54d-44a0-8dac-bd56983361d5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}LightColor](ms-xhelp:///?Id=4e53536e-0e75-40e4-b03b-b019d98ac416){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Name](ms-xhelp:///?Id=29acb0db-e5eb-4237-bac2-66adedac5d97){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}NumberOfHistogramIntervals](ms-xhelp:///?Id=c69e6fdd-b650-40b5-b682-2e756c7068b1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}OpenCloseDrawMode](ms-xhelp:///?Id=bae7773f-6320-4702-9a19-cecaf25af616){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}OptimizePiePointPositions](ms-xhelp:///?Id=a73ccd8c-894d-4d09-b342-4ec8f1e94711){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PhongAlpha](ms-xhelp:///?Id=ce89398a-c6aa-43ed-8ed5-0100e7fadf2f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PieType](ms-xhelp:///?Id=57f33d6c-301a-4591-91e3-e7ceedb21c91){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PieWithSameRadius](ms-xhelp:///?Id=e894f6e2-ba93-4754-9047-7b15442a17bc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PointsToolTipFormat](ms-xhelp:///?Id=cf8384c9-3230-4fe9-be97-7c783ed04087){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PointWidth](ms-xhelp:///?Id=1a47270e-96c9-4de0-9b55-6e8224cf600c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PriceDownColor](ms-xhelp:///?Id=7ba9f9b1-d6bb-411c-b56f-65f9cfaf1366){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PriceUpColor](ms-xhelp:///?Id=e93d3932-1dc3-4c70-9e54-3db4954d4171){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PyramidMode](ms-xhelp:///?Id=e559ad78-891b-48c2-9e9e-a2861cef53c8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Radar Type](ms-xhelp:///?Id=ad454e9d-24ca-427b-a99c-0c4ab3769127){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}RadarStyle](ms-xhelp:///?Id=a33fb316-5fbb-4808-8e2d-ae7277fdc323){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}RelatedPoints](ms-xhelp:///?Id=a89e4717-7a20-49b6-a254-1313f0c80d9e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ReversalAmount](ms-xhelp:///?Id=5f84e7c4-ff16-4a7a-922a-213ad58166a9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Rotate](ms-xhelp:///?Id=59dd57c4-9a7d-43e7-a306-2f1886f3aeb0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ScatterConnectType](ms-xhelp:///?Id=c0043bdb-efad-41f2-95d0-fec32105e597){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ScatterSplineTension](ms-xhelp:///?Id=0b11f1c2-9d77-4613-8eb6-9177563b649d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SeriesToolTipFormat](ms-xhelp:///?Id=102871a4-9d65-4a6d-b7ed-3ecb173ea010){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ShadingMode](ms-xhelp:///?Id=3597217d-ec9f-4cb2-a9ed-786ec5b541d5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ShadowInterior](ms-xhelp:///?Id=7edf9597-a5ad-4f20-b862-de2ffd2a8166){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ShadowOffset](ms-xhelp:///?Id=60277f02-ad20-4b8f-ac45-741553dcbe21){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ShowDataBindLabels](ms-xhelp:///?Id=70e44da3-2556-4ea9-ab99-baaf7b489f63){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ShowHistogramDataPoints](ms-xhelp:///?Id=83857219-12b5-4805-aec5-195b05c5f4dd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ShowTicks](ms-xhelp:///?Id=2eefa07e-36c9-432f-8475-b65048aa98ae){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SmartLabels](ms-xhelp:///?Id=9e613de8-5230-4cbb-8441-f5ad41f32736){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Spacing](ms-xhelp:///?Id=0d608eb4-6d44-4e5a-a179-b6344311d05e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SpacingBetweenSeries](ms-xhelp:///?Id=73a0bf5d-5021-413a-ab63-84549046ee6d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SpacingBetweenPoints](ms-xhelp:///?Id=78758df9-3433-4820-a021-de1e27d50dcb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StepItem.Inverted](ms-xhelp:///?Id=d797a7d2-80a8-4f10-b078-7ec2367dcf1d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Summary](ms-xhelp:///?Id=8aece66e-678d-4b7c-8c20-df3150abb849){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Symbol](ms-xhelp:///?Id=8a407945-bd18-4c61-9d96-64847d39efdb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Text (Series)](ms-xhelp:///?Id=8b52bf14-ec11-44c8-ac46-8f01de56b7f6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Text (Style)](ms-xhelp:///?Id=56b65dfb-065a-452a-9a5c-cbb7ffc1f9a8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TextColor](ms-xhelp:///?Id=35fd72e9-ec45-4b57-801b-130abf2732a3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TextFormat](ms-xhelp:///?Id=33622e3c-42b4-4380-aee0-f3464bf7ac74){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TextOffset](ms-xhelp:///?Id=713c5681-2c59-4a31-a615-9b8ae6d7e73e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TextOrientation](ms-xhelp:///?Id=aa4bb329-973d-4db7-be89-0f653122a0b7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ToolTip](ms-xhelp:///?Id=d747ea9d-8f82-4b78-a663-21803a0eba3f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ToolTipFormat](ms-xhelp:///?Id=07508f5b-af17-4e17-a15a-2a2a3c2b8857){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Visible](ms-xhelp:///?Id=344ebd2c-7047-40ef-9984-3c76a0b2259d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}VisibleAllPies](ms-xhelp:///?Id=75937854-bcf4-4298-9a3b-2dca7100b6df){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}XType](ms-xhelp:///?Id=6438c750-460e-47fa-8f32-fc26555eaed2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}YType](ms-xhelp:///?Id=ef96fac2-ee2d-4f74-8325-1fb57872dd83){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ZOrder](ms-xhelp:///?Id=a9cb9ebf-58fb-4231-8b65-17913e071e0b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Hyperlink for chart series](ms-xhelp:///?Id=4569c96a-a9d1-474e-bb15-c67b926a5a06){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Set Open/Close tips color](ms-xhelp:///?Id=49955ce1-89b2-4a61-9cb9-462ef904e566){style="TEXT-DECORATION: none"}
:::::
