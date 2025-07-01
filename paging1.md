::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=46c018d3-07a5-40bb-b673-cbdfc0b59622){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e23a3cc3-8e63-498b-b420-adaafaef0b7c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}
:::

## Paging {#paging style="tab-stops: 0pt"}

Essential Grid offers complete navigation support to easily switch between the pages using the pager bar available at the bottom of the Grid control. It facilitates splitting up huge grid data and displays viewable sets of Grid rows on each page. By selecting the respective page numbers you can navigate to the other pages. You can also limit the number of pages.

The Grid control for MVC exposes the following properties and methods to enable and control the paging feature.

Properties

 

::: {align="center"}
+-------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| Property    | Description                                                                                                                                                                                                | Type of property | Value it accepts | Any other dependencies/sub-properties associated |
+-------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| AllowPaging | Enables the paging feature.                                                                                                                                                                                | Boolean          | True/false       | NA                                               |
|             |                                                                                                                                                                                                            |                  |                  |                                                  |
|             |                                                                                                                                                                                                            |                  |                  |                                                  |
+-------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| PageSize    | Sets the number of records to be displayed in a single grid page. The same number of records will be available for the next page and you will be able to navigate between these pages using the pager bar. | Int              | +ve Integers     | Dependent on AllowPaging                         |
|             |                                                                                                                                                                                                            |                  |                  |                                                  |
|             | Default page size is 12.                                                                                                                                                                                   |                  |                  |                                                  |
+-------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| PageCount   | Sets the number of pages to be displayed in the pager bar. You can limit the number of pages to be displayed using this property.                                                                          | Int              | +ve Integers     | Dependent on AllowPaging                         |
|             |                                                                                                                                                                                                            |                  |                  |                                                  |
|             | Default page count is 10.                                                                                                                                                                                  |                  |                  |                                                  |
+-------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| CurrentPage | Set the current page to the Grid control.                                                                                                                                                                  | Int              | +ve Intergers    | Dependent on AllowPaging                         |
+-------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
:::

 

Methods

 

::: {align="center"}
+--------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------+-------------------+
| Method             | Descriptions                                                                                                                                                                                            | Parameters                     | Return type       |
+--------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------+-------------------+
| EnablePaging()     | Used to enable the paging feature in the Grid control.                                                                                                                                                  | No parameter                   | IGridBuilder\<T\> |
+--------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------+-------------------+
| AllowPaging(bool)  | Used to enable/disable the paging feature.                                                                                                                                                              | Enable as bool                 | IPagerBuilder     |
+--------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------+-------------------+
| PageSize(Int32)    | Sets the number of records to be displayed in a single grid page. The same number of records will be available for the next page and you will be able to navigate between these pages using pager bars. | Page size as integer           | IPagerBuilder     |
|                    |                                                                                                                                                                                                         |                                |                   |
|                    |                                                                                                                                                                                                         |                                |                   |
+--------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------+-------------------+
| PageCount(Int32)   | Sets the number of pages to be displayed in the pager bar. You can limit the number of pages to be displayed using this property.                                                                       | Page count as integer          | IPagerBuilder     |
|                    |                                                                                                                                                                                                         |                                |                   |
|                    |                                                                                                                                                                                                         |                                |                   |
+--------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------+-------------------+
| CurrentPage(Int32) | Set the current page to the Grid control.                                                                                                                                                               | Current page number as integer | IPagerBuilder     |
+--------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------+-------------------+
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=e23a3cc3-8e63-498b-b420-adaafaef0b7c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=f231008e-6708-4007-9eee-587e94e8787d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Pager Customization](ms-xhelp:///?Id=8ce07526-d42f-4487-b4de-814b941fd037){style="TEXT-DECORATION: none"}
::::::
