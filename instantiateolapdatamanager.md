::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=28cb9d07-0fa3-4836-86e5-348b70a2d3c0){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6f58f70b-2a5c-4307-abdc-50a0c6d7022d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How To](ms-xhelp:///?Id=0cccf1dc-494c-4681-99d6-a46f21e26b73){.d2h_breadcrumbsNormal}
:::

## Instantiate OlapDataManager {#instantiate-olapdatamanager style="tab-stops: 0pt"}

To instantiate the OlapDataManager, we shall use any of the following methods.

**[]{style="FONT-SIZE: 12pt"}** 

Binding OLAP Client to the Server:

**[]{style="FONT-SIZE: 12pt"}** 

+----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                |
| [OlapDataManager olapDataManager = new OlapDataManager(connectionString);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                |
| [this.olapClient1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                |
| [this.olapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                  |
+----------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                      |
| [Dim olapDataManager As OlapDataManager = New OlapDataManager(connectionString)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                      |
| [Me.olapClient1.OlapDataManager = olapDataManager]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                      |
| [Me.olapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                           |
+----------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-SIZE: 12pt"}** 

Binding OLAP Client to the Offline Cube:

**[]{style="FONT-SIZE: 12pt"}** 

+-----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                |
|                                                                                                                 |
| [OlapDataManager olapDataManager = new OlapDataManager(connectionString); ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                 |
| [this.olapClient1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                 |
| [this.olapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                   |
+-----------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                      |
| [Dim olapDataManager As OlapDataManager = New OlapDataManager(connectionString)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                      |
| [Me.olapClient1.OlapDataManager = olapDataManager]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                      |
| [Me.olapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                           |
+----------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-SIZE: 12pt"}** 

Binding OLAP Client to the Server using Data Provider:

**[]{style="FONT-SIZE: 12pt"}** 

+-----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                |
|                                                                                                                 |
| [AdomdDataProvider dataProvider = new AdomdDataProvider(connectionString);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                 |
| [OlapDataManager olapDataManager = new OlapDataManager(dataProvider);]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                 |
| [this.olapClient1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                 |
| [this.olapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                   |
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
| [Me.olapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                            |
+-----------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-SIZE: 12pt"}** 

[]{#related-topics}
::::
