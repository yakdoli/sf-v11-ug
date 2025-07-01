::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=ccab2740-d581-4489-a09d-a29014549d48){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f764d3df-be17-4773-927f-db6747ef6dc6){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How-To](ms-xhelp:///?Id=f56652ff-a795-456f-ba4a-e1b615c58fdd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Bind an OlapReport with OlapDataManager](ms-xhelp:///?Id=f3af9bf1-81b6-4cac-ba97-1b669376f47a){.d2h_breadcrumbsNormal}
:::

### LoadReportDefinitionFile {#loadreportdefinitionfile style="tab-stops: 0pt"}

You can bind the OlapReport as xml file to OlapDataManager using the LoadReportDefinitionFile method. This contains two steps as follows:

1.   Loading the report definition file and

2.   Loading a specific report in that file by giving its name

 

The following code snippet will illustrate the loading of the report definition file:

+---------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                   |
| [olapDataManager.LoadReportDefinitionFile([@\"C:\\SampleReports\\SalesAnalysis.xml\"]{style="COLOR: #a31515"});\                                  |
| olapDataManager.LoadReport([\"SalesOn2003\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**[      ]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                  |
| [olapDataManager.LoadReportDefinitionFile([\"C:\\SampleReports\\SalesAnalysis.xml\"]{style="COLOR: #a31515"})\                                   |
| olapDataManager.LoadReport([\"SalesOn2003\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
