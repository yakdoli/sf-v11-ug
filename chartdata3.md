::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=1e37851a-5ced-427b-82a4-bbc104f0e869){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6215755d-4818-4b36-8499-4af3aa989671){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=895ee437-1738-49ea-b2a5-247d41ce7a5b){.d2h_breadcrumbsNormal}
:::

## Chart Data {#chart-data style="tab-stops: 0pt"}

Built-in Support for Data Binding

Essential Chart has built-in support for binding to IEnumerable data sources.

The chart series, data points, and axis labels are the ones that can be data-bound.

 

Series properties

  -------- ----------------------------------------------------------------------------------------------------- ------------------ ------------------ ------------
  Name     Description                                                                                           Property Type      Value it Accepts   Dependency
  BindTo   Allows you to get or set the data source of the series and fields that are used to render the axes.   ChartAdvDataBind   ChartAdvDataBind   NA
  -------- ----------------------------------------------------------------------------------------------------- ------------------ ------------------ ------------

 

ChartAdvDataBind Properties

  ------------ --------------------------------------------------------- --------------- ------------------ ------------------------------------------------------------------------------------------------------------------------------
  Name         Description                                               Property Type   Value it Accepts   Dependency
  DataSource   Allows you to get or set the data source of the series.   IEnumerable     IEnumerable        NA
  XName        Allows you to get or set the field name of the x-axis.    String          Any string value   Depends on DataSource---DataSource should be set and the field name should be the same as any entry in the IEnumerable list.
  YNames       Allows you to get or set the field names of the y-axis.   String\[\]      Any string array   Depends on DataSource---DataSource should be set and the field name should be the same as any entry in the IEnumerable list.
  ------------ --------------------------------------------------------- --------------- ------------------ ------------------------------------------------------------------------------------------------------------------------------

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Chart Data Binding with IEnumerables](ms-xhelp:///?Id=6215755d-4818-4b36-8499-4af3aa989671){style="TEXT-DECORATION: none"}
::::
