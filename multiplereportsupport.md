::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=268be4ee-b8a4-42f9-8f9a-219eb7406c97){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d6400d99-db53-481f-8258-8455f70aec39){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Silverlight](ms-xhelp:///?Id=c006b39c-6aa2-4637-b7de-3e7b6cb3f9f9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Features](ms-xhelp:///?Id=4ae10797-e3a8-4270-b8ba-34441d2e1a3d){.d2h_breadcrumbsNormal}
:::

## Multiple Report Support {#multiple-report-support style="tab-stops: 0pt"}

OLAP Client control allows you to create any number of reports for a current session. You can also perform Add, Remove and Rename operations on reports in the current session.

 

[]{#_Add_Report}Add Report

Add report will add a new report to the current session and set that report as the current report of the session. By using this, you can add any number of reports to the current session. The report will be listed in the Report List present in the OLAP Client Tool Bar.

 

Code Snippet for Adding a Report

 

+------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                   |
|                                                                                    |
| [ //// To add a new report to current session]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                    |
| [\                                                                                 |
|  this.OlapClient.AddReport();]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                             |
+------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                  |
|                                                                                   |
| [\'// To add a new report to current session]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                   |
| [Me.OlapClient.AddReport()]{style="FONT-FAMILY: 'Courier New'"}                   |
+-----------------------------------------------------------------------------------+

 

[]{#_Remove_Report}Remove Report

 

Remove Report will remove the current report from the session by deleting it.

Code snippet for Removing the Report:

 

+-----------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                       |
| [//// To remove the current report from current session\              |
| this.OlapClient.RemoveReport();]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                |
+-----------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                          |
|                                                                                           |
| [\'To remove the current report from current session]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                           |
| [Me.OlapClient.RemoveReport()]{style="FONT-FAMILY: 'Courier New'"}                        |
+-------------------------------------------------------------------------------------------+

 

[]{#_Rename_Report}Rename Report

Rename Report will get the new name for the current report and rename it with the new name.

Code snippet for Renaming the Report:

 

+-----------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                       |
| [//// To rename the current report \                                  |
| this.OlapClient.RenameReport();]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                |
+-----------------------------------------------------------------------+

 

+-----------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                       |
| [\'To rename the current report ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                       |
| [Me.OlapClient.RenameReport()]{style="FONT-FAMILY: 'Courier New'"}    |
+-----------------------------------------------------------------------+

 

[]{#related-topics}
::::
