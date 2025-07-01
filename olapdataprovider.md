::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=264352e0-540c-4186-b1f0-d19250dae50b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}
:::

## OlapDataProvider {#olapdataprovider style="tab-stops: 0pt"}

The database connectivity related works are all taken care of by this part of the base. Here we are using **Microsoft.AnalysisService.AdomdClient** data provider. Establishing the connection, checking the state of the connection and closing the connection are basic operations provided by the general data provider, but we need some information beyond this in order to provide the input for our controls. 

This part of the base will get the connection information and establish a connection with the specified data source and retrieve the information from the data base and store it in its classes. This part of the base will have the required logic to retrieve the information from the data base and store it in the **object of class** in **Data** namespace.

 All the information about the connected cube will intersect and be stored in **object of classes** in **Data** namespace, which are equivalent to the classes in the **AdomdClient**. This information is required to provide the input for OLAP controls.

Important class in DataProvider namespace:

[·      ]{style="FONT-FAMILY: Symbol"}AdomdDataProvider

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}AdomdDataProvider](ms-xhelp:///?Id=264352e0-540c-4186-b1f0-d19250dae50b){style="TEXT-DECORATION: none"}
::::
