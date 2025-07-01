::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8b30f45b-688b-4466-913b-6cbc53caab21){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=da28afc6-9583-4f76-b5c7-4f29d3061263){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OlapReport](ms-xhelp:///?Id=5df0d4a2-dd21-4743-9142-c97b5f6c86e0){.d2h_breadcrumbsNormal}
:::

### Paging {#paging style="tab-stops: 0pt"}

Paging enables the user to view large records by breaking them into smaller segments.

Paging feature can be achieved by setting the *EnablePaging* property to *true* in a report.

The following code snippet demonstrates how to enable paging in current report:

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                     |
| [olapDataManager.CurrentReport.EnablePaging = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[true]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                                |
| [olapDataManager.CurrentReport.EnablePaging = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The user can customize the page settings such as current page, page size (for both row and column).

The following code explains how to customize current page and page size settings:

+-------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                            |
|                                                                                                             |
| [olapDataManager.CurrentReport.PagerOptions.CategorialCurrentPage = 1;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                             |
| [olapDataManager.CurrentReport.PagerOptions.SeriesCurrentPage = 2;]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                             |
| [olapDataManager.CurrentReport.PagerOptions.CategorialPageSize = 50;]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                             |
| [olapDataManager.CurrentReport.PagerOptions.SeriesPageSize = 50;]{style="FONT-FAMILY: 'Courier New'"}       |
+-------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                            |
| [olapDataManager.CurrentReport.PagerOptions.CategorialCurrentPage = 1]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                            |
| [olapDataManager.CurrentReport.PagerOptions.SeriesCurrentPage = 2]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                            |
| [olapDataManager.CurrentReport.PagerOptions.CategorialPageSize = 50]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                            |
| [olapDataManager.CurrentReport.PagerOptions.SeriesPageSize = 50]{style="FONT-FAMILY: 'Courier New'"}       |
+------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
