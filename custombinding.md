::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=34221523-67af-4851-a010-ad9c3d9ecb5c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=199235e7-f9f5-4e00-a240-9493a274c73e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Data Binding](ms-xhelp:///?Id=4e3356df-66f2-4ab8-801e-d5ab48a4e93a){.d2h_breadcrumbsNormal}
:::

### Custom Binding {#custom-binding style="tab-stops: 0pt"}

Essential Grid processes the data source by using the built-in LINQ expressions to perform paging, sorting, grouping, filtering, and editing actions. However, in some cases you may want to bypass the built-in data source processing and process the data manually. This is called "custom binding."****

Essential Grid supports custom binding to perform paging, sorting, and filtering actions.

 

Properties

 

::: {align="center"}
+------------------+----------------------------------------------------------------+------------------+--------------------+--------------------------------------------------+
| Property         | Description                                                    | Type of property | Value it accepts   | Any other dependencies/sub-properties associated |
+------------------+----------------------------------------------------------------+------------------+--------------------+--------------------------------------------------+
| EnableOnDemand   | Gets or sets a value indicating whether OnDemand is enabled.   | Boolean          | True/false         | NA                                               |
+------------------+----------------------------------------------------------------+------------------+--------------------+--------------------------------------------------+
| TotalRecordCount | Gets or sets the total record count.                           | Long             | 0 to long.MaxValue |                                                  |
|                  |                                                                |                  |                    |                                                  |
|                  |                                                                |                  |                    |                                                  |
+------------------+----------------------------------------------------------------+------------------+--------------------+--------------------------------------------------+
| EnableOnDemand   | Gets or sets the value indicating whether OnDemand is enabled. | Boolean          | True/false         |                                                  |
+------------------+----------------------------------------------------------------+------------------+--------------------+--------------------------------------------------+
:::

 

Methods

 

+-----------------------------------------+------------------------------------------------------------------------------------------+--------------------------+-------------------------------+
| Method                                  | Description                                                                              | Parameters               | Return type                   |
+-----------------------------------------+------------------------------------------------------------------------------------------+--------------------------+-------------------------------+
| EnableOnDemand()                        | Used to enable the custom binding mode to True.                                          | \-\--                    | IGridBuilder\<T\>             |
|                                         |                                                                                          |                          |                               |
|                                         |                                                                                          |                          |                               |
+-----------------------------------------+------------------------------------------------------------------------------------------+--------------------------+-------------------------------+
| TotalRecordCount()                      | Used to set the total record count.                                                      | Long                     | 0 to long.MaxValue            |
|                                         |                                                                                          |                          |                               |
|                                         |                                                                                          |                          |                               |
+-----------------------------------------+------------------------------------------------------------------------------------------+--------------------------+-------------------------------+
| Where(List\<FilterConditions\> filters) | **IQueryable** extension method is used to filter the record from the given data source. | List of FilterConditions | Filter conditions collections |
+-----------------------------------------+------------------------------------------------------------------------------------------+--------------------------+-------------------------------+
| GridActions\<T\>(Long totalrecordcount) | **GridActionResult** method is used to call the custom binding grid post actions.        | Total record count       | Action result                 |
+-----------------------------------------+------------------------------------------------------------------------------------------+--------------------------+-------------------------------+

 

You can work with the custom binding feature through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}GridBuilder

[·      ]{style="FONT-FAMILY: Symbol"}GridPropertiesModel

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through GridBuilder](ms-xhelp:///?Id=805542a9-0792-4ba7-b279-4ae8d340ffca){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through GridPropertiesModel](ms-xhelp:///?Id=3241059f-9e01-4332-920f-a5cab3d02f94){style="TEXT-DECORATION: none"}
:::::
