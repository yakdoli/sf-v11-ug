::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7e155502-4f8b-468d-9348-aacb5116d274){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=564c5564-f535-4c48-a93d-cc1b74d58d20){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How-To](ms-xhelp:///?Id=f56652ff-a795-456f-ba4a-e1b615c58fdd){.d2h_breadcrumbsNormal}
:::

## Establish the connection for a Cube file {#establish-the-connection-for-a-cube-file style="tab-stops: 0pt"}

A valid string is required to establish connection for an OlapDataManager.

Here is the code snippet that demonstrates how to connect cube file by using connection string:

+---------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                              |
|                                                                                                               |
|     OlapDataManager dataManager = new OlapDataManager("DataSource= AdventureWorks_Ext.cub; Provider=MSOLAP"); |
+---------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                  |
|                                                                                                   |
|     Dim dataManager As New OlapDataManager("DataSource= AdventureWorks_Ext.cub; Provider=MSOLAP") |
+---------------------------------------------------------------------------------------------------+

Or

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                         |
|                                                                                                                                                                          |
|     Syncfusion.Olap.DataProvider.IDataProvider dataProvider = new Syncfusion.Olap.DataProvider.AdomdDataProvider("DataSource= AdventureWorks_Ext.cub; Provider=MSOLAP"); |
|                                                                                                                                                                          |
|     OlapDataManager dataManager = new OlapDataManager(dataProvider);                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                |
|     Dim dataProvider As Syncfusion.Olap.DataProvider.IDataProvider = New Syncfusion.Olap.DataProvider.AdomdDataProvider("DataSource= AdventureWorks_Ext.cub; Provider=MSOLAP") |
|                                                                                                                                                                                |
|     Dim dataManager As New OlapDataManager(dataProvider)                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
