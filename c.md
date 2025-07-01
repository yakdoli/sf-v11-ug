::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=799e2efa-958a-4000-be8b-3cf70586cb97){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=956d1014-1840-4f2a-b51c-92650f93fc17){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=71321e9c-336c-4c1c-a127-be9f135ad4bb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart control events](ms-xhelp:///?Id=f9b89118-6918-44f0-b20c-6f93ed6cf64c){.d2h_breadcrumbsNormal}
:::

### [\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 10pt"}

[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} 

[//ChartRegionDoubleClick Event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}

[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ChartRegionDoubleClick += [new]{style="COLOR: blue"} Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler([this]{style="COLOR: blue"}.chartControl1_ChartRegionDoubleClick);]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} chartControl1_ChartRegionDoubleClick([object]{style="COLOR: blue"} sender, ChartRegionMouseEventArgs e)]{style="FONT-FAMILY: 'Courier New'"}

[{]{style="FONT-FAMILY: 'Courier New'"}

[    [if]{style="COLOR: blue"} ([this]{style="COLOR: blue"}.chkRegionDoubleClick.Checked)]{style="FONT-FAMILY: 'Courier New'"}

[    {]{style="FONT-FAMILY: 'Courier New'"}

[        [if]{style="COLOR: blue"} (e.Region.SeriesIndex == 0)]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[            OutputText(String.Format([\"Double Click over Series 1 Column {0} Point : {1}\"]{style="COLOR: #a31515"}, e.Region.PointIndex,e.Point));]{style="FONT-FAMILY: 'Courier New'"}

[            ShowChartRegion([\"ChartSeries\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}

[        }]{style="FONT-FAMILY: 'Courier New'"}

[        [else]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[            OutputText(String.Format([\"Double Click over {0}\"]{style="COLOR: #a31515"}, e.Region.Description.ToString()));]{style="FONT-FAMILY: 'Courier New'"}

[            ShowChartRegion(e.Region.Description.ToString());]{style="FONT-FAMILY: 'Courier New'"}

[        }]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[    }]{style="FONT-FAMILY: 'Courier New'"}

[}]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[//Usage of Button property in ChartRegionMouseDown Event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}

[void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ chartControl1_ChartRegionMouseDown([object]{style="COLOR: blue"} sender, [ChartRegionMouseEventArgs]{style="COLOR: teal"} e)]{style="FONT-FAMILY: 'Courier New'"}

[{]{style="FONT-FAMILY: 'Courier New'"}

[  [if]{style="COLOR: blue"}(e.Button==[MouseButtons]{style="COLOR: teal"}.Right)]{style="FONT-FAMILY: 'Courier New'"}

[     [Console]{style="COLOR: teal"}.WriteLine([\"Chart Region Mouse Down:=\"]{style="COLOR: maroon"}+e.Point.ToString());]{style="FONT-FAMILY: 'Courier New'"}

[}]{style="FONT-FAMILY: 'Courier New'"}

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[.NET]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                   |
| [\'ChartRegionDoubleClick Event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                   |
| [AddHandler]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Me]{style="COLOR: blue"}.chartControl1.ChartRegionDoubleClick, [AddressOf]{style="COLOR: blue"} [Me]{style="COLOR: blue"}.chartControl1_ChartRegionDoubleClick]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                   |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} chartControl1_ChartRegionDoubleClick([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} ChartRegionMouseEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                   |
| [    [If]{style="COLOR: blue"} [Me]{style="COLOR: blue"}.chkRegionDoubleClick.Checked [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                   |
| [        [If]{style="COLOR: blue"} e.Region.SeriesIndex = 0 [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                   |
| [            OutputText(\[String\].Format([\"Double Click over Series 1 Column {0} Point : {1}\"]{style="COLOR: maroon"}, e.Region.PointIndex, e.Point))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                   |
| [            ShowChartRegion([\"ChartSeries\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                   |
| [        [Else]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                   |
| [            OutputText(\[String\].Format([\"Double Click over {0}\"]{style="COLOR: maroon"}, e.Region.Description.ToString()))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                   |
| [            ShowChartRegion(e.Region.Description.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                   |
| [        [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                   |
| [    [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                   |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                   |
| [\'Usage of Button property in ChartRegionMouseDown Event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                   |
| [Private Sub ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[chartControl1_ChartRegionMouseDown([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} ChartRegionMouseEventArgs)]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                                                                                                                                   |
| [  [    If ]{style="COLOR: blue"}[e.Button = MouseButtons.Right ]{style="COLOR: black"}[Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                   |
| [        ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.WriteLine([\"Chart Region Mouse Down:=\"]{style="COLOR: maroon"}+e.Point.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                   |
| [    End If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                   |
| [End Sub]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p268} 

[]{#related-topics}
::::
