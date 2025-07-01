::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=564c5564-f535-4c48-a93d-cc1b74d58d20){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=fd77911d-e883-4bf8-a0b0-fee3352c3121){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How-To](ms-xhelp:///?Id=f56652ff-a795-456f-ba4a-e1b615c58fdd){.d2h_breadcrumbsNormal}
:::

## Connect ActivePivot Server through XMLA {#connect-activepivot-server-through-xmla style="tab-stops: 0pt"}

The user can connect the Active Pivot server through XMLA (XML for Analysis) services using the OlapDataManager in our OLAP controls.

The following code illustrates how to connect to Active Pivot server:

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                       |
| [// Connecting to Active Pivot ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[S]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[erver]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                  |
|                                                                                                                                                                                                                                                                                                                                       |
|     OlapDataManager DataManager = new OlapDataManager(@"Data Source=http://localhost:8081/var_s/xmla;  Initial Catalog=VaRCubes; User ID=; Password=; Transport Compression=None;");                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                       |
| [DataManager]{style="FONT-FAMILY: 'Courier New'"}[.DataProvider.ProviderName = Syncfusion.Olap.DataProvider.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Providers]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.ActivePivot;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                   |
| [\' Connecting to Active Pivot ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[S]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[erver]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                           |
|                                                                                                                                                                                                                                                                                                                                                   |
| [Dim DataManager As OlapDataManager = New OlapDataManager(\"Data Source=http://localhost:8081/var**\_**s/xmla;  Initial Catalog=VaRCubes; User ID=; Password=; Transport Compression=None;\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                   |
| [DataManager]{style="FONT-FAMILY: 'Courier New'"}[.DataProvider.ProviderName = Syncfusion.Olap.DataProvider.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Providers]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.ActivePivot]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[[Click here]{style="FONT-FAMILY: 'Arial','sans-serif'"}](http://quartetfs.com/) for more information about Active Pivot server.

[]{#related-topics}
::::
