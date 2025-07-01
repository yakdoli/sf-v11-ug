::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=01073408-6fb5-4943-a653-da9fd3358a53){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3201d260-ac75-44e9-a6a8-89fb0852ba7e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=01073408-6fb5-4943-a653-da9fd3358a53){.d2h_breadcrumbsNormal}
:::

## Data Binding {#data-binding style="tab-stops: 0pt"}

To instantiate the OlapDataManager and to bind the cube data in client control, we shall use any of the following method.

 

Binding OLAP Client to the Server:

+----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                |
| [OlapDataManager olapDataManager = new OlapDataManager(connectionString);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                |
| [this.olapClient1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                |
| [this.olapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}                                             |
+----------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                      |
| [Dim olapDataManager As OlapDataManager = New OlapDataManager(connectionString)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                      |
| [Me.olapClient1.OlapDataManager = olapDataManager]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                      |
| [Me.olapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}                                                      |
+----------------------------------------------------------------------------------------------------------------------+

 

Binding OLAP Client to the Offline Cube:

+-----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                |
|                                                                                                                 |
| [OlapDataManager olapDataManager = new OlapDataManager(connectionString); ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                 |
| [this.olapClient1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                 |
| [this.olapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}                                              |
+-----------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                      |
| [Dim olapDataManager As OlapDataManager = New OlapDataManager(connectionString)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                      |
| [Me.olapClient1.OlapDataManager = olapDataManager]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                      |
| [Me.olapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}                                                      |
+----------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 12pt; FONT-WEIGHT: normal"} 

Binding OLAP Client to the Server using Data Provider:

+-----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                |
|                                                                                                                 |
| [AdomdDataProvider dataProvider = new AdomdDataProvider(connectionString);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                 |
| [OlapDataManager olapDataManager = new OlapDataManager(dataProvider);]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                 |
| [this.olapClient1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                 |
| [this.olapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}                                              |
+-----------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                      |
|                                                                                                                       |
| [Dim dataProvider As AdomdDataProvider = New AdomdDataProvider(connectionString)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                       |
| [Dim olapDataManager As OlapDataManager = New OlapDataManager(dataProvider)]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                       |
| [Me.olapClient1.OlapDataManager = olapDataManager]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                       |
| [Me.olapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}                                                       |
+-----------------------------------------------------------------------------------------------------------------------+

[]{#_Display_Mode} 

Table 12: Properties

::: {align="center"}
  --------------------- ----------------------------------------------------------------------------------------------------------------------------------------------------- ------------- ------------------- -----------------------
  Property              Description                                                                                                                                           Type          Data type           Reference link
  AdomdDataProvider     Multidimensional data provider uses ADOMD for .NET to connect and retrieve data from the multidimensional data source                                 Server side   AdomdDataProvider                       -
  OlapDataManager       Sets the cube mode. It contains connection proprerty, current report, cube name, cube schema and pivot engine for rendering chart and grid controls   Server side   OlapDataManager     \-
  --------------------- ----------------------------------------------------------------------------------------------------------------------------------------------------- ------------- ------------------- -----------------------
:::

 

Table 13: DataBind() Method

::: {align="center"}
  ------------ ---------------------------------------------------------------------------------------------------- ------------ ------------- ------------- ----------------
  Methods      Description                                                                                          Parameters   Type          Return type   Reference link
  DataBind()   The method is used to fill or bind data present in the DataManager into the chart and grid control   \-           Server side   void          \-
  ------------ ---------------------------------------------------------------------------------------------------- ------------ ------------- ------------- ----------------
:::

 

Sample Link

A sample demo is available at the following link:

**..\\Syncfusion\\EssentialStudio\\\<Version Number\>\\BI\\Web\\OlapClient.Web\\Samples\\3.5\\OlapClient\\ OlapClientDemo**

[]{#related-topics}
::::::
