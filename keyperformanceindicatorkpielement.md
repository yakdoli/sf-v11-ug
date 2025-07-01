::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=38ddc27c-e76a-47c6-a9a8-c73920b082b1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1a15ccf7-d241-47a4-bb20-13139c8b7b6a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OlapReport](ms-xhelp:///?Id=5df0d4a2-dd21-4743-9142-c97b5f6c86e0){.d2h_breadcrumbsNormal}
:::

### Key Performance Indicator (KPI) Element {#key-performance-indicator-kpi-element style="tab-stops: 0pt"}

Key Performance Indicator(KPI) is a collection of calculations that are associated with a measure group in a cube that are used to evaluate business success. Typically, these calculations are a combination of Multidimensional Expressions (MDX) or calculated members. The KPIs also have an additional metadata that provides information about how client applications should display the results of the KPI\'s calculations.

The different types of KPI Indicators are:

[·      ]{style="FONT-FAMILY: Symbol"}KPI Goal

[·      ]{style="FONT-FAMILY: Symbol"}KPI Status

[·      ]{style="FONT-FAMILY: Symbol"}KPI Trend

[·      ]{style="FONT-FAMILY: Symbol"}KPI Value

We can create a KPI element by specifying its name and giving details of the indicator that are included in the element.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]               ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                          |
|                                                                                                                                                                                          |
| [KpiElements]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ kpiElement = [new]{style="COLOR: blue"} [KpiElements]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [// Specifying the KPI Element name and configuring its Indicators]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                    |
|                                                                                                                                                                                          |
| [kpiElement.Elements.Add([new]{style="COLOR: blue"} [KpiElement]{style="COLOR: #2b91af"} { Name = [\"Internet Revenue\"]{style="COLOR: #a31515"},  ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [ShowKPIGoal = [true]{style="COLOR: blue"}, ShowKPIStatus = [true]{style="COLOR: blue"}, ShowKPIValue = [true]{style="COLOR: blue"}, ]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                          |
| [ShowKPITrend = [true]{style="COLOR: blue"} });]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ kpiElement [As]{style="COLOR: blue"} KpiElements = [New]{style="COLOR: blue"} KpiElements()]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                              |
| [\' Specifying the KPI Element name and configuring its Indicators]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                              |
| [kpiElement.Elements.Add([New]{style="COLOR: blue"} KpiElement [With]{style="COLOR: blue"} {.Name =  ]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                              |
| [\"Internet Revenue\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #c00000"}[, .ShowKPIGoal = [True]{style="COLOR: blue"}, .ShowKPIStatus = [True]{style="COLOR: blue"}, ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| [ .ShowKPIValue = [True]{style="COLOR: blue"}, .ShowKPITrend = [True]{style="COLOR: blue"}})]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
