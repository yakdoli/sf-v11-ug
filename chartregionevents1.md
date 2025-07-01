::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f9b89118-6918-44f0-b20c-6f93ed6cf64c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=393a3dbc-753a-468e-a151-edd46ad0bedc){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=71321e9c-336c-4c1c-a127-be9f135ad4bb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart control events](ms-xhelp:///?Id=f9b89118-6918-44f0-b20c-6f93ed6cf64c){.d2h_breadcrumbsNormal}
:::

### Chart Region Events {#chart-region-events style="tab-stops: 0pt"}

 

The Chart handles the following mouse related events when the user interacts with the Chart using mouse, on certain specific regions in the Chart - Axis Labels, Chart Points or a custom region.

 

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionClick Event

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionMouseEnter Event

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionMouseHover Event

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionMouseMove Event

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionMouseLeave Event

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionMouseUp Event

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionMouseDown Event

[·      ]{style="FONT-FAMILY: Symbol"}ChartRegionDoubleClick Event

 

The above events are raised with a **ChartRegionMouseEventArgs** that contain the following properties.

 

::: {align="center"}
  ------------------------------------ -------------------------------------------------------
  ChartRegionMouseEventArgs Property   Description
  Point                                Represents the client point where the event occurred.
  Region (Expanded below)              Returns the region associated with this event.
  Button                               Returns the right mouse button actions.
  ------------------------------------ -------------------------------------------------------
:::

 

The **Region** property above includes several useful information about the kind of region the user is currently interacting with:

 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| ChartRegion Property              | Description                                                                                                                      |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| Description                       | A text description of this region.                                                                                               |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| Type                              | Specifies the type of region. Possible values:                                                                                   |
|                                   |                                                                                                                                  |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**SeriesPoint -** interacted on a data point.                                              |
|                                   |                                                                                                                                  |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**HorAxisLabel -** interacted on a horizontal axis                                         |
|                                   |                                                                                                                                  |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**VerAxisLabel -** interacted on a vertical axis                                           |
|                                   |                                                                                                                                  |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**ChartCustom -** interacted with a region that is none of the above.                      |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| IsChartPoint                      | Indicates whether the region is a Chart Point in the ChartSeries. This simply checks if the above mentioned Type is SeriesPoint. |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| SeriesIndex                       | The index into the **Series** array of the Chart in which this point occurs. If the Type is SeriesPoint.                         |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| PointIndex                        | The index into the **Points** array of the ChartSeries in which this point occurs. If the Type is SeriesPoint.                   |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| Region                            | The client region that represents this logical region.                                                                           |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
| ToolTip                           | Specifies the tooltip for this region.                                                                                           |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------------+
:::

 

ChartRegionDoubleClick and ChartRegionMouseDown Events

 

[]{#related-topics}
::::::
