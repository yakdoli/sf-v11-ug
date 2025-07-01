::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=ad8f80be-db8d-485a-b71c-ef670e32a912){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bec6fa92-8167-4ad3-a2a7-cf41904c296a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Grid]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=ea758680-939d-4d65-8abe-8c3be198af29){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Data Source](ms-xhelp:///?Id=ad8f80be-db8d-485a-b71c-ef670e32a912){.d2h_breadcrumbsNormal}
:::

### Binding to OLAP Data {#binding-to-olap-data style="tab-stops: 0pt"}

**OlapData** can be bound to **OlapGrid** with the help of **OlapDataManager**. **OlapDataManager** requires **OlapReport** which contains Dimension and Measure elements.

[Refer here for OLAP Data binding]{.UGHyperlink} [\
\
]{.UGHyperlink}XAML Configuration

XAML configuration is one of the important features of OlapGrid. It helps you to configure the control entirely using XAML by eliminating the required code in code behind.

\
Use Case Scenarios

This feature will help you to set the Data source, Report and UI properties in a simple and elegant manner, when you want to perform the entire configuration in XAML.

Tables for Properties, Methods, and Events

 

  ----------------------------- ---------------------------------------------------------------------------------------- --------------------- ------------------- ----------------
  Property                      Description                                                                              Type                  Data  Type          Reference Link
  DataSource.ConnectionString   Specifies the connection string of the DataManager                                       Attached Property     String              \-
  DataSource.ConnectionName     Specifies the connection name which is available in App.Config file of the application   Attached Property     String              \-
  DataSource.DataManagerName    Specifies the DataManager name                                                           Attached Property     String              \-
  SharedDataManagerName         Specifies the DataManager name which is available in shared data manager collection      Attached Property     String              \-
  ReportName                    Species the OLAP report name                                                             CLR                   String              \-
  CurrentCubeName               Specifies the current cube name of a OLAP report                                         CLR                   String              \-
  CategoricalAxis               Specifies the Categorical axis of the OLAP report                                        Dependency Property   CategoricalAxis     \-
  SeriesAxis                    Specifies the Series axis of the OLAP report                                             Dependency Property   SeriesAxis          \-
  SlicerAxis                    Specifies the Slicer axis of the OLAP report                                             Dependency Property   SlicerAxis          \-
  CalculatedMembers             Specifies the Calculated Members of the OLAP report                                      Dependency Property   CalculatedMembers   \-
  ----------------------------- ---------------------------------------------------------------------------------------- --------------------- ------------------- ----------------

 

[]{#related-topics}
::::
