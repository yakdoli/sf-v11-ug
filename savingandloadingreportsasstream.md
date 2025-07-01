::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7eef30ef-f489-405e-bc62-1fda8d32b723){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bcf348b2-e470-438e-90e5-1aeb649ad6a7){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=01073408-6fb5-4943-a653-da9fd3358a53){.d2h_breadcrumbsNormal}
:::

## Saving and loading report(s) as stream {#saving-and-loading-reports-as-stream style="tab-stops: 0pt"}

[]{#_Saving_report(s)_as}Saving report(s) as stream

GetReportStream() - By using this method, user can get the current report set as a stream which can be stored anywhere, for example, database.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                             |
|                                                                                                                                                                              |
| [Stream]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ reportStream = [this]{style="COLOR: blue"}.olapClient1.GetReportStream();]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                     |
|                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ reportStream [As]{style="COLOR: blue"} Stream = [Me]{style="COLOR: blue"}.olapClient1.GetReportStream()]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#_LoadReportStream}[]{#_LoadReportStream(_)} 

 

 

[]{#_Loading_report(s)_as}Loading report(s) as stream

LoadReportStream() - By using this method, user can load the report as a stream. This method will accept a stream format of the report as argument. By invoking this method the reports in the stream format will be populated in the report list as well as in chart/grid control.  The following code snippet will illustrate how to load the report in stream format.

 

+-------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                          |
|                                                                                                                                           |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.olapClient1.LoadReportStream(reportStream);]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                       |
|                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.olapClient1.LoadReportStream(reportStream)]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------+

[]{#_AutoExecute}[[]{style="FONT-SIZE: 12pt"}]{.Heading4Char} 

 

Table 19: Methods

 

::: {align="center"}
+--------------------+------------------------------------------------------------------+------------+-------------+-------------+----------------+
| Methods            | Description                                                      | Parameters | Type        | Return type | Reference link |
+--------------------+------------------------------------------------------------------+------------+-------------+-------------+----------------+
| GetReportStream()  | Used to get the current session of the report in stream format.  | \-         |             |             | \-             |
|                    |                                                                  |            |             |             |                |
|                    |                                                                  |            | Server side | Stream      |                |
+--------------------+------------------------------------------------------------------+------------+-------------+-------------+----------------+
| LoadReportStream() | The method is used to load the report which is in stream format. | Stream     |             | void        | \-             |
|                    |                                                                  |            |             |             |                |
|                    |                                                                  |            | Server side |             |                |
+--------------------+------------------------------------------------------------------+------------+-------------+-------------+----------------+
:::

 

Sample Link

A sample demo is available at the following link:

**..\\Syncfusion\\EssentialStudio\\\<Version Number\>\\BI\\Web\\OlapClient.Web\\Samples\\3.5\\OlapClient\\** **ReportsAsStreamDemo**

[]{#related-topics}
:::::
