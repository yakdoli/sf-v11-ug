::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8bb855c7-07f5-4839-b7b9-7a66da8852ec){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=097815eb-2181-4399-8c02-488923d12378){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart Controls](ms-xhelp:///?Id=a31cf788-e675-45c2-abaf-c10c20850169){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Sparkline](ms-xhelp:///?Id=8bb855c7-07f5-4839-b7b9-7a66da8852ec){.d2h_breadcrumbsNormal}
:::

### Properties {#properties style="tab-stops: 0pt"}

Table 180: Properties of Sparkline Control

::: {align="center"}
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| Property                                                        | Description                                                                                                  | Type                 | Data Type                                      | Reference links |
+=================================================================+==============================================================================================================+======================+================================================+=================+
| [SparkLineType]{style="COLOR: black"}[]{style="COLOR: #c00000"} | [Get or set the type of spark lines.]{style="COLOR: black"}                                                  |  Dependency property | SparkLineTypes -- Enum {Line, Column, WinLoss} | NA              |
|                                                                 |                                                                                                              |                      |                                                |                 |
|                                                                 | By default, it is set to Line type.[]{style="COLOR: #c00000"}                                                |                      |                                                |                 |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| ItemSource[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}      | Gets or sets the data source for sparkline data points[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}       |  Dependency Property | IEnumerable                                    |  NA             |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| DisplayMemberPath                                               | Gets or sets the property name that has to be taken as data for displaying points                            | Dependency Property  | String                                         | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| FirstPointHighlightBrush                                        | Gets or sets the brush used to highlight first data point in spark line                                      |  Dependency Property | Brush                                          |  NA             |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| IsFirstPointHighlighted                                         | Helps to enable or disable highlighting of first data point in spark line                                    | Dependency Property  | Bool                                           | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| LastPointHighlightBrush                                         | Gets or sets the brush used to highlight last data point in spark line                                       |  Dependency Property | Brush                                          |  NA             |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| IsLastPointHighlighted                                          | Helps to enable or disable highlighting of last data point in spark line                                     | Dependency Property  | Bool                                           | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| HighPointHighlightBrush                                         | Gets or sets the brush used to highlight highest data point in spark line                                    |  Dependency Property | Brush                                          |  NA             |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| IsHighPointHighlighted                                          | Helps to enable or disable highlighting of highest data point in spark line                                  | Dependency Property  | Bool                                           | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| LowPointHighlightBrush                                          | Gets or sets the brush used to highlight lowest data point in spark line                                     |  Dependency Property | Brush                                          |  NA             |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| IsLowPointHighlighted                                           | Helps to enable or disable highlighting of lowest data point in spark line                                   | Dependency Property  | Bool                                           | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| NegativePointHighlightBrush                                     | Gets or sets the brush used to highlight negative data points in spark line                                  |  Dependency Property | Brush                                          |  NA             |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| IsNegativePointHighlighted                                      | Helps to enable or disable highlighting of negative data point in spark line                                 | Dependency Property  | Bool                                           | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| MarkerColor                                                     | Gets or sets the brush of the markers in spark line. This property has effect over Line type spark line only | Dependency Property  | Brush                                          | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
| IsMarkerEnabled                                                 | Helps to enble or disable markers in line type spark line                                                    | Dependency Property  | Bool                                           | NA              |
+-----------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-----------------+
:::

 

***[]{style="COLOR: black"}*** 

[]{#related-topics}
:::::
