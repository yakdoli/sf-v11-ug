::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=86caec87-83c5-41b2-9ab3-59a33858fc49){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=51d32de6-c69e-46fb-869b-158f587b0580){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OLAP Data Processing](ms-xhelp:///?Id=86caec87-83c5-41b2-9ab3-59a33858fc49){.d2h_breadcrumbsNormal}
:::

### Steps in processing OLAP Data {#steps-in-processing-olap-data style="tab-stops: 0pt"}

To process the OLAP data:

1.   Get the input to establish a connection to the specified data source. The connection information can be given as a connection string that contains information about the data source.

Example connection string: "DataSource = localhost; Initial Catalog = Adventure Works DW";

2.   Connect to a server or an off-line cube as a data source.

3.   Once the connection is established, provide input for data processing. You can give two types of inputs to process the OLAP data. They are:

[·      ]{style="FONT-FAMILY: Symbol"}MDX Query - You can write a MDX Query for the database and give that query as an input.

[·      ]{style="FONT-FAMILY: Symbol"}OlapReport - You can create an OLAP report and give that report as an input to the OlapDataManager.

4.   The output will not differ, based on the input type. The processing method will differ in OLAP base, based on the input type.

5.   If MDX query as given as an input then the query will be executed on the connected data base.

6.   If **OlapReport** is given as an input:

a.   MDX query specification will be created based on the **OlapReport**.

b.   From the MDX query specification, the MDX query will be generated with the help of **OlapQueryBuilderEngine**.

c.   The generated query will be executed on the connection database.

7.   Once the query is executed either from the MDX query input or from the **OlapReport** input, the result is obtained.

8.   This result set will be formatted to provide input for the controls. The formatted input should be passed to the controls.

9.   The output will be displayed in the controls.

 

In Silverlight:

 

1.   The OlapDataManager requires a OlapReport and a Virtual Channel in the form of *OlapDataManager*.

2.   The *OlapDataManager* is a set to control and in the *DataBind* method, the control will make an asynchronous call with the help of a virtual channel provided in *OlapDataManager.*

3.   Now with the help of WCF Service, the control communicates with Olap base to retrieve *CellSet*.

4.   Now the Control passes the obtained *CellSet* to the *OlapDataManager* and in turn the *OlapDataManager* returns the *PivotEngine* to the control.

5.   The output will reflect in the controls.

 

[]{#related-topics}
::::
