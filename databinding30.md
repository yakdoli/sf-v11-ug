::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=af3644f2-ceb1-4f8e-aeba-172b41e685cf){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8c33a32c-f616-4733-b345-77fcff34986e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=094c35c7-db8e-4341-9619-16644b2a4e34){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid WPF Controls](ms-xhelp:///?Id=1249c159-5431-465a-b1af-1cf1e5e90ac8){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[GridData Control](ms-xhelp:///?Id=e9aeb59d-d6ab-4862-87f7-4f169b1d763e){.d2h_breadcrumbsNormal}
:::

### []{style="FONT-SIZE: 10pt"}[]{#p257}Data Binding {#data-binding style="tab-stops: 0pt"}

Data binding is the master feature of the GridData control. Grid must be bound to an external data source to display the data. GDC supports the following data sources such as, Data Tables, Data Sets or Custom collections of type List, Binding List, Observable Collection or Collection View Source. These data source can have multiple nested tables, which will be displayed hierarchically by the grouping grid.

 

Data Binding mechanisms

 

Following are the data binding mechanisms:

 

[·      ]{style="FONT-FAMILY: Symbol"}Using Data Providers-Object Data Provider,  XML Data Provider and usage of Data Context

[·      ]{style="FONT-FAMILY: Symbol"}Using ADO.NET Data-Data Table,  Data Set  and Data Row

[·      ]{style="FONT-FAMILY: Symbol"}Using Business Objects-List, Binding List, Observable Collection, Collection View Source

[·      ]{style="FONT-FAMILY: Symbol"}XAML Binding-Elaborates on data binding using XAML code

[·      ]{style="FONT-FAMILY: Symbol"}Notify Property Changes-Elaborates on notifying the underlying data source changes to the grid

[·      ]{style="FONT-FAMILY: Symbol"}Data Error Validation-Discusses on the support to validate the grid data and display error information

[·      ]{style="FONT-FAMILY: Symbol"}Synchronize Current Selection-Discusses about synchronization of changes in the current with another control

[·      ]{style="FONT-FAMILY: Symbol"}Unbound Columns-Discusses on the addition of unbound columns to the grid

**[]{style="COLOR: #15428b"}** 

Important Data Binding Properties

 

The following table contains some data binding properties and their corresponding descriptions:

 

::: {align="center"}
  ----------------------- ------------------------------------------------------------------------------------------------------
  Property                Description
  DataContext             Gets or sets the data context for binding. It simplifies the data binding.
  ItemsSource             Binds the grid to a collection object.
  AutoPopulateColumns     When set to true, it extracts the column from the data set and populates the Grid automatically.
  AutoPopulateRelations   When set to true, it extracts the  relation from the data set and populates  the Grid automatically.
  ----------------------- ------------------------------------------------------------------------------------------------------
:::

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Data Providers](ms-xhelp:///?Id=178dbf0f-2296-4543-8755-936895db281b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Database Data](ms-xhelp:///?Id=86552501-7419-4a9e-9a7b-f2909b82ad9b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Business Objects](ms-xhelp:///?Id=66235b65-df60-4b65-a8bc-ab8690d64914){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}XAML Binding](ms-xhelp:///?Id=dfce93f1-0093-43a1-8572-e92ee74e3541){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Complex Property Binding](ms-xhelp:///?Id=3abb3606-2d04-489d-9cba-5080dfafcff1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Notify Property changes](ms-xhelp:///?Id=2359a552-f60c-4011-8654-49996601c72e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Error Validation](ms-xhelp:///?Id=785192f5-87e7-4dbf-a255-2a7c4a642b04){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Synchronize Current Selection](ms-xhelp:///?Id=1098bed4-cf1d-4e2d-b9a2-d6e1203b7ed6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Unbound Columns](ms-xhelp:///?Id=7862bd6a-80a0-40d5-8922-fb286224b2c7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}UnboundRows](ms-xhelp:///?Id=7a755ab1-03a3-419c-a474-05e40828d3a2){style="TEXT-DECORATION: none"}
:::::
