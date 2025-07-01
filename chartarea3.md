::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=0f9ea29f-1949-43ff-8a4f-fd1479411f90){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=26574a97-1fe1-4f3d-803d-3a7568072747){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=71321e9c-336c-4c1c-a127-be9f135ad4bb){.d2h_breadcrumbsNormal}
:::

## Chart Area {#chart-area style="tab-stops: 0pt"}

 

Essential Chart comes with chart divide area support, wherein a single ChartArea can be divided into equal squares to display more than one chart(pie, funnel or pyramid). To enable this **ChartArea.DivideArea** property should be set to **true**.

 

By enabling this property, the following are possible.

 

[·      ]{style="FONT-FAMILY: Symbol"}Retrieving the bounds of each sections of pie, funnel or pyramid charts.

[·      ]{style="FONT-FAMILY: Symbol"}It is possible to show series name as title for individual section of a pie, funnel and pyramid chart types.

[·      ]{style="FONT-FAMILY: Symbol"}Draw pie series with the same radius.

 

**GetSeriesBounds()** method can be used to get the bounds of the DividedArea when ChartArea.DivideArea is set to true.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                        |
| []{style="COLOR: black; FONT-SIZE: 12pt"}                                                                                                                              |
|                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.[chartControl1.ChartArea.GetSeriesBounds(series);]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                  |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.[chartControl1.ChartArea.GetSeriesBounds(series)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

**ShowSeriesTitle** property is used to display the series name as title for each section of the pie, funnel, pyramid charts in the divided area.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                        |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                  |
|                                                                                                                                                                                                                       |
| [ChartSeries.ConfigItems.PieItem.ShowSeriesTitle = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[;\                                                      |
| ChartSeries.ConfigItems.FunnelItem.ShowSeriesTitle = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[;\                                                    |
| ChartSeries.ConfigItems.PyramidItem.ShowSeriesTitle = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                                                     |
| [ChartSeries.ConfigItems.PieItem.ShowSeriesTitle = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True\                                                                                                        |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartSeries.ConfigItems.FunnelItem.ShowSeriesTitle = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True\                                                   |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ChartSeries.ConfigItems.PyramidItem.ShowSeriesTitle = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

A sample which demonstrates the chartdividearea support is available in the following sample installation location.

 

[\<sample installed location\>\\Syncfusion\\EssentialStudio\\Version Number\\Windows\\Chart.Windows\\Samples\\2.0\\Chart Appearance\\Chart Divide Area]{.UGHyperlink}

 

See Also

 

[PieWithSameRadius]{.UGHyperlink}[]{style="COLOR: black"}

[]{#p192} 

[]{#related-topics}
::::
