::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c9d25979-bb19-441c-a310-fd0ec16ede8e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=abd42068-df28-4d00-bb9b-28f0b91b8086){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart Series](ms-xhelp:///?Id=c9d25979-bb19-441c-a310-fd0ec16ede8e){.d2h_breadcrumbsNormal}
:::

### Series Customization {#series-customization style="tab-stops: 0pt"}

 

Essential Chart offers numerous appearance and behavior customization capabilities at the series level and on individual points.

Some of these options are applicable only for the whole series while the rest could be applied on the specific data points. Similarly, some of these options are specific to certain chart types.

Note that styles set at the series level automatically propagate to the points in the series.

Interestingly the Chart control allows the user to edit the styles of a series by double-clicking it during run-time. This feature can be turned on by setting the AllowUserEditStyles property to true.

The table displayed below lists the customization options available in the Chart Series and their restrictions:

 

::: {align="center"}
  Customization Option              Applies to Series or DataPoints\*   Applies to Chart Type
  --------------------------------- ----------------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  AngleOffset                       Series                              Pie chart
  Border                            Series and points                   Pyramid chart, Funnel chart, Area chart, Bar chart, Bubble chart, Column chart, Candle chart, Renko chart, Three Line Break chart, Box and Whisker chart, Gantt chart, Histogram chart, Tornado chart, Polar chart, Radar chart, and Pie chart.
  BubbleType                        Series                              Bubble chart
  ColumnDrawMode                                                        Column chart, Column Range chart, Bar chart, Box and Whisker chart, and Gantt chart.
  ColumnWidthMode                   Series                              Column charts
  ColumnFixedWidth                  Series                              Column charts
  ColumnType                        Series                              Column charts
  ColorsMode                        Series                              Renko chart
  DarkLightPower                    Series                              Renko chart
  DisplayShadow                     Series and points                   Area chart, Bar chart, Bubble chart, Column chart, Stacking Column chart, Stacking Column100 chart, Line chart, Spline chart, Rotated Spline chart, Step Line chart, Candle chart, Kagi chart, Point and Figure chart, Renko chart, Three Line Break charts, Gantt chart, Histogram chart, Tornado chart, Combination chart, and Box and Whisker chart.
  DisplayText                       Series and points                   All chart types.
  DoughnutCoeficient                Series                              Pie chart
  DrawColumnSeparatingLines         Series                              Column chart
  DrawErrorBars                     Series                              Column chart, Line chart, and HiLo chart.
  DrawHistogramNormalDistribution   Series                              Histogram chart
  DrawSeriesNameInDepth             Series                              All chart types.
  ElementBorders                    Series and points                   Area charts, Bar charts, Bubble chart, Column charts, Line charts, Candle chart, Renko chart, Three Line Break chart, Box and Whisker chart, Gantt chart, Tornado chart, Polar chart, and Radar chart.
  EnablePhongStyle                  Series                              Bubble chart.
  ErrorBarsSymbolShape              Series                              Column chart, Line chart, and HiLo chart.
  ExplodedAll                       Series                              Pie chart and Doughnut chart.
  ExplodedIndex                     Series                              Pie chart
  ExplosionOffset                   Series                              Pie chart
  FancyToolTip                      Series                              All chart types.
  FigureBase                        Series                              Funnel chart and Pyramid chart.
  FillMode                          Series                              Pie chart
  FunnelMode                        Series                              Funnel chart and Pyramid chart.
  Font                              Series and points                   All chart types.
  GanttDrawMode                     Series                              Gantt chart
  GapRatio                          Series                              Funnel chart and Pyramid chart.
  Gradient                          Series                              Pie chart
  HeightBox                         Series                              Point and Figure chart
  HeightByAreaDepth                 Series                              Pie chart
  HeightCoeficient                  Series                              Pie chart
  HighlightInterior                 Series                              Bar charts, Pie chart, Funnel chart, Pyramid chart, Bubble chart, Column chart, Area chart, Stacking Area chart, StackingArea100 chart, Line charts, Box and Whisker chart, Gantt chart, and Tornado chart.
  HitTestRadius                     Series                              Line chart and Step Line chart.
  ImageIndex                        Series and points                   Area charts, Bar charts, Bubble chart, Column charts, Line charts, Candle chart, Renko chart, Three Line Break chart, Box and Whisker chart, Gantt chart, Tornado chart, Polar chart, and Radar chart.
  Images                            Series and points                   Area charts, Bar charts, Bubble chart, Column charts, Line charts, Candle chart, Renko chart, Three Line Break chart, Box and Whisker chart, Gantt chart, Tornado chart, Polar chart, and Radar chart.
  InSideRadius                      Series                              Pie chart
  Interior                          Series and points                   All chart types.
  LabelPlacement                    Series                              Funnel chart and Pyramid chart.
  LabelStyle                        Series                              Funnel chart, Pyramid chart, and Pie chart.
  LegendItem                        Series                              All chart types.
  LightAngle                        Series                              Scatter chart, Column charts, Bar charts, Box and Whisker chart, Gantt chart, Histogram chart, Tornado chart, Polar chart, and Radar chart.
  LightColor                        Series                              Scatter chart, Column charts, Bar charts, Box and Whisker chart, Gantt chart, Histogram chart, Tornado chart, Polar chart, and Radar chart.
  Name                              Series                              All chart types.
  NumberOfHistogramIntervals        Series                              Histogram chart
  OpenCloseDrawMode                 Series                              HiLoOpenClose chart
  OptimizePiePointPositions         Series                              Pie chart
  PhongAlpha                        Series                              Column chart
  PieType                           Series                              Pie chart
  PieWithSameRadius                 Series                              Pie chart and Doughnut chart.
  PointsToolTipFormat               Series                              All chart types.
  PointWidth                        Series and points                   Gantt chart.
  PriceDownColor                    Series                              Financial types
  PriceUpColor                      Series                              Financial types
  PyramidMode                       Series                              Pyramid chart
  Radar Type                        Series                              Polar chart and Radar chart.
  RadarStyle                        Series                              Polar chart and Radar chart.
  RelatedPoints                     Series and points                   Gantt chart
  ReversalAmount                    Series                              Kagi chart, Point and Figure chart, and Renko chart.
  Rotate                            Series                              Column charts, Bar charts, Area charts, Line chart, Spline chart, Step Line chart, Candle chart, HiLo chart, HiLoOpenClose chart, Kagi chart, Box and Whisker chart, Histogram chart, Polar chart, and Radar chart.
  ScatterConnectType                Series                              Scatter chart
  ScatterSplineTension              Series                              Scatter chart
  SeriesToolTipFormat               Series                              Area charts
  ShadingMode                       Series                              Column chart, Bar charts, Candle chart, HiLo chart, HiLoOpenClose chart, Tornado chart, Box and Whisker chart, Gantt chart, Histogram chart, Polar chart, and Radar chart.
  ShadowInterior                    Series and points                   Column charts, Bubble chart, Line charts, Bar charts, Candle chart, Kagi chart, Point and Figure chart, Renko chart, Three Line Break chart, Box and Whisker chart, Gantt chart, Histogram chart, Tornado chart, Pie chart, Polar chart, and Radar chart.
  ShadowOffset                      Series and points                   Column charts, Bubble chart, Line charts, Bar charts, Candle chart, Kagi chart, Point and Figure chart, Renko chart, Three Line Break chart, Box and Whisker chart, Gantt chart, Histogram chart, Tornado chart, Pie chart, Polar chart, and Radar chart.
  ShowDataBindLabels                Series                              Pie chart, Doughnut chart, Funnel chart, and Pyramid chart.
  ShowHistogramDataPoints           Series                              Histogram chart
  ShowTicks                         Series                              Pie chart
  SmartLabels                       Series                              All chart types.
  Spacing                           Series and Points.                  Column charts, Bar charts, Box and Whisker chart, Gantt chart, and Tornado chart.
  Spacing between Series            Series                              Area charts, Bar charts, Line charts, Bubble chart, Financial charts, Gantt chart, Histogram chart, Tornado chart, Combination chart, and Box and Whisker chart.
  SpacingBetweenPoints              Series Points                       Column chart, Bar chart, HiLo chart, HiLoOpenClose chart, Candle chart, Tornado chart, and Box and Whisker chart.
  StepItem.Inverted                 Series                              Step Area chart and Step Line chart.
  Summary                           Series                              All chart types.
  Symbol                            Series and points                   Column chart, Bar chart, Bubble chart, Financial chart, Line chart, Box and Whisker chart, Gantt chart, Tornado chart, and Radar chart.
  Text (Series)                     Series                              All chart types.
  Text (Style)                      Series and Points                   All chart types.
  TextColor                         Series and points                   All chart types.
  TextFormat                        Series and points                   All chart types.
  TextOffset                        Series and points                   All chart types.
  TextOrientation                   Series and points                   All chart types.
  ToolTip                           Series and points                   All chart types.
  ToolTipFormat                     Series and points                   All chart types.
  Visible                           Series                              All chart types.
  VisibleAllPies                    Series                              Pie chart
  XType                             Series                              All chart types.
  YType                             Series                              All chart types.
  ZOrder                            Series                              Gantt chart, Stacking Bar chart, StackingBar100 chart, Stacking Column chart, StackedColumn100 chart, Stacking Area chart, and StackingArea100 chart.
:::

 

[\* ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}[Indicates whether the property affects ALL the points in the series or if the property can also be set on individual points.]{.BodyText1Char}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Properties Table](ms-xhelp:///?Id=af27ad9a-ff48-44b0-bd02-1af110fcde72){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Pie Related Properties](ms-xhelp:///?Id=903580f9-d4ed-47de-9168-815d57156914){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Column Related Properties](ms-xhelp:///?Id=e287228d-46fd-45b6-b9d8-a2e281d3637d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}BubbleType](ms-xhelp:///?Id=ad4f0304-b28a-471d-93c2-39e7ac5be11c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ScatterConnectType and ScatterSplineTension](ms-xhelp:///?Id=162d2655-18b9-4b3c-8ae4-056c91e28d64){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}RadarType](ms-xhelp:///?Id=1566b969-72ed-4baa-baa9-d33d78205251){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}RadarStyle](ms-xhelp:///?Id=0713ab18-3a85-440f-b53e-eec805b52735){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Funnel and Pyramid Chart Related Properties](ms-xhelp:///?Id=ce4a48a7-5e18-416d-b46e-57394f84acc0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PriceDownColor and PriceUpColor](ms-xhelp:///?Id=7263c237-2aed-4cf1-9119-bbb89d59cf35){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ReversalAmount, ColorsMode and DarkLightPower](ms-xhelp:///?Id=f0759de0-b3c7-4498-8c8d-7a106dd6cda7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Height Box](ms-xhelp:///?Id=2fc4f0b6-1f10-49d9-84e6-700f13b45660){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}OpenCloseDrawMode](ms-xhelp:///?Id=0f2c5a03-ad9b-41b9-adf7-d897e307b302){style="TEXT-DECORATION: none"}
:::::
