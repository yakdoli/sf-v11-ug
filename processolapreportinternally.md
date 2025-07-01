::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c58c4416-5c07-4c96-8150-2b5cec2cda75){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=07403d21-6692-443a-857f-10f4cc279e61){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How-To](ms-xhelp:///?Id=f56652ff-a795-456f-ba4a-e1b615c58fdd){.d2h_breadcrumbsNormal}
:::

## Process OlapReport Internally {#process-olapreport-internally style="tab-stops: 0pt"}

Once the OlapReport is created and bound to the OlapDataManager, the data processing begins. By binding the report, the given report will be set as the current report of the OlapDataManager and it will invoke the two important methods that let the way to generate the **MDX** **query** and **CellSet**.

[·      ]{style="FONT-FAMILY: Symbol"}NotifyReportChanged

[·      ]{style="FONT-FAMILY: Symbol"}NotifyElementModified

 

NotifyReportChanged

After initialization the data processing begins. When the **NotifyReportChanged** is invoked, it triggers the **ReportChaned** event, which will be handled by the control level.

 

NotifyElementModified

The **NotifyElementModified** method begins the processing by invoking the **ExecuteCellSet()** method, which create the **CellSet** and **PivotEngine** based on the OlapReport.

The **ExecuteCellSet()** method checks whether the user has given the MDX query. If the query exists, it will invoke an overloaded method of the **ExecuteCellSet(string *query*)** which in turn calls the **ExecuteCellSet(string query, bool b1, bool b2)** of DataProvider class. The given query will be executed in the DataProvider class and the **CellSet** will be produced.

If the query does not exist, the overloaded method of **ExecuteCellSet** (**MDXQuerySpecification** **querySpecification)** will get invoked. This method will invoke the **MDXQuerySpecification** creation and from there the query creation will be invoked and the query will be returned. The **ExeccuteCellSet()** method receives the query and passes it to the data provider's **ExecuteCellset** method. The query will be executed there on the connected database and a **CellSet** will be returned.  From the **CellSet**, the **PivotEngine** will be created, from which the controls can get their input.

[]{#related-topics}
::::
