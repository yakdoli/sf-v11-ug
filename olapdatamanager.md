::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=264352e0-540c-4186-b1f0-d19250dae50b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=381852ea-8913-4771-8507-0eb92d259bff){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}
:::

## OlapDataManager {#olapdatamanager style="tab-stops: 0pt"}

OlapDataManager is the most important class in the whole OLAP Base. All the information transfers from the control to OLAP base will happen through this class and this will retain the current state of the base objects. The connection is established in the Data provider of the OLAP Base, but the information required in establishing the connection is given to the data provider through the **OlapDataManager**.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Table 3: Constructors

::: {align="center"}
  Constructors                         Description                                                                                                                  Parameters          Return Type   Reference Link
  ------------------------------------ ---------------------------------------------------------------------------------------------------------------------------- ------------------- ------------- ----------------
  OlapDataManager()                    Default constructor                                                                                                          \-                  Void          \-
  OlapDataManager(string)              Accepts the connection string as argument and passes it to the Data Provider to establish the connection with data source.   String              Void          \-
  OlapDataManager(AdomdDataProvider)   Accepts the Data Provider as argument and processes the cube that is connected with the given data provider.                 AdomdDataProvider   Void          \-
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Establishing connection with the SSAS server

The following code snippet describes establishing connection with the server:

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                |
| [\                                                                                                                                                                                                                                                             |
| [OlapDataManager]{style="COLOR: #2b91af"} olapDataManager = [new]{style="COLOR: blue"} [OlapDataManager]{style="COLOR: #2b91af"}([\"DataSource=localhost; Initial Catalog=Adventure Works DW\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                           |
|                                                                                                                                                                                                            |
| [OlapDataManager olapDataManager = [New]{style="COLOR: blue"} OlapDataManager(\"[DataSource=localhost; Initial Catalog=Adventure Works DW]{style="COLOR: #a31515"}\")]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Or

 

Establishing Connection with the SSAS server through Data Provider

The following code snippet describes establishing connection with the server:

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                              |
| [AdomdDataProvider]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dataProvider = [new]{style="COLOR: blue"} [AdomdDataProvider]{style="COLOR: #2b91af"}([\"DataSource=localhost; Initial Catalog=Adventure Works DW\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                              |
| [OlapDataManager]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ olapDataManager = [new]{style="COLOR: blue"} [OlapDataManager]{style="COLOR: #2b91af"}(dataProvider);]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dataProvider [As]{style="COLOR: blue"} AdomdDataProvider = [New]{style="COLOR: blue"} AdomdDataProvider(\"[DataSource=localhost; Initial Catalog=Adventure Works DW]{style="COLOR: #a31515"}\")]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapDataManager [As]{style="COLOR: blue"} OlapDataManager = [New]{style="COLOR: blue"} OlapDataManager(dataProvider)]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 Establishing connection with the offline cube

The following code snippet describes establishing connection with the offline cube:

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                  |
| [\                                                                                                                                                                                                                                                                                               |
| [OlapDataManager]{style="COLOR: #2b91af"} olapDataManager = [new]{style="COLOR: blue"} [OlapDataManager]{style="COLOR: #2b91af"}([@\"Data Source = C:\\ Common\\Data\\OfflineCube\\Adventure_Works_Ext.cub; Provider = MSOLAP;\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                   |
| [OlapDataManager olapDataManager = [New]{style="COLOR: blue"} OlapDataManager([\"Data Source = C:\\\\ Common\\\\Data\\\\OfflineCube\\\\Adventure_Works_Ext.cub; Provider = MSOLAP;\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Arial','sans-serif'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Establishing connection with XMLA Server:

XML for Analysis (XMLA) is a standard that allows the client applications to transfer multi-dimensional or OLAP data sources, which is available in the Mondrian Server. The back and forth communication is done using the web standards -- HTTP, SOAP, and XML.  The query language used is MDX, is most widely supported for reporting from multi-dimensional data stores.

Use Case Scenarios

XMLA provides the most efficient way to access an OLAP database over the Internet.

Connecting to Mondrian Server

 The following code illustrates how to connect to the Mondrian server:

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                              |
| [// Connecting to Mondrian ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[S]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[erver]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                             |
|                                                                                                                                                                                                                                                                                              |
| [OlapDataManager DataManager = new OlapDataManager(]{style="FONT-FAMILY: 'Courier New'"}[\"Data Source = http://localhost:8080/mondrian/xmla; Initial Catalog = FoodMart;\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[);]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                                                                                              |
| [DataManager]{style="FONT-FAMILY: 'Courier New'"}[.DataProvider.ProviderName = Syncfusion.Olap.DataProvider.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Providers]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Mondrian;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                     |
| [\' Connecting to Mondrian ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[S]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[erver]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                     |
| [Dim DataManager As OlapDataManager = New OlapDataManager(\"Datasource = http://bi.syncfusion.com:8080/mondrian/xmla; Initial Catalog=FoodMart;\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                                                                                                     |
| [DataManager]{style="FONT-FAMILY: 'Courier New'"}[.DataProvider.ProviderName = Syncfusion.Olap.DataProvider.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Providers]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Mondrian]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}         |
|                                                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[Click here](http://mondrian.pentaho.com/) for more information about Mondrian XMLA configurations.

 

Connecting to Active Pivot Server

 The following code illustrates how to connect to Active Pivot server:

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                 |
| [// Connecting to Active Pivot ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[S]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[erver]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                                                                                                                                                                                                 |
|     OlapDataManager DataManager = new OlapDataManager(@"Data Source=http://localhost:8081/var_s/xmla;  Initial Catalog=VaRCubes; User ID=; Password=; Transport Compression=None;");                                                                                                            |
|                                                                                                                                                                                                                                                                                                 |
| [DataManager]{style="FONT-FAMILY: 'Courier New'"}[.DataProvider.ProviderName = Syncfusion.Olap.DataProvider.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Providers]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.ActivePivot;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                         |
| [\' Connecting to Active Pivot ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[S]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[erver]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                         |
| [Dim DataManager As OlapDataManager = New OlapDataManager(\"Data Source=http://localhost:8081/var**\_**s/xmla;  Initial Catalog=VaRCubes; User ID=; Password=; Transport Compression=None;\")]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                                                                         |
| [DataManager]{style="FONT-FAMILY: 'Courier New'"}[.DataProvider.ProviderName = Syncfusion.Olap.DataProvider.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Providers]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.ActivePivot]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}          |
|                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[Click here](http://quartetfs.com/) for more information on Active Pivot server.

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Properties and Methods](ms-xhelp:///?Id=381852ea-8913-4771-8507-0eb92d259bff){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}UseWhereClauseForSlicing](ms-xhelp:///?Id=556b26e3-2dfe-4765-840b-49b938b9e391){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Drill Through](ms-xhelp:///?Id=cdc6202d-a2ef-4943-aea5-26bc6a4bb4cd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Localization](ms-xhelp:///?Id=624804f7-1d99-4cb0-af9d-53c99dec96c8){style="TEXT-DECORATION: none"}
:::::
