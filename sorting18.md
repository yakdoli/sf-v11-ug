::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=70fd8b44-be81-4f68-88ee-ad6f5a74bc02){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=325040fb-eeba-43e1-a434-e87058839b53){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=45772664-2e19-4523-9f80-67c80a02ab5e){.d2h_breadcrumbsNormal}
:::

## Sorting {#sorting style="tab-stops: 0pt"}

Sorting is defined as the process of arranging items/records in some ordered sequence. Essential Grid for Mobile MVC supports arranging table data in ascending or descending order based on the column header that is touched. The order switches between ascending, descending, and clearing the sort order each time you touch a column header for sorting.

It supports two types of sorting---normal and menu sorting.

**Properties and Methods**

Properties

::: {align="center"}
+---------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------+
| Name                                                                            | Description                                                                                                                                                                                | Type of the Property                                                                       | Value it Accepts                                                                                 | Dependency                                                                               |
+---------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------+
| [AllowSorting]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}      | [Enables the sorting feature. Default value is False.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}                                                                         | [bool[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"} | [True/False[]{style="COLOR: black"}]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"} | [NA]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}                         |
+---------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------+
| [SortDescriptors]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}   | [Collection that is used to add sorted columns programmatically at initial load with sort directions.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}                         | [IList\<SortDescriptor\>]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}      | []{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}                                   | [Dependent on AllowSorting.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"} |
+---------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------+
| [AllowMultiSorting]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"} | [Enables multicolumn sorting. Setting the value to true, will allow the user to sort multiple columns.Default value is False.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"} | [bool]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}                         | [True/False]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}                         | [Dependent on AllowSorting.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"} |
+---------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------+
| [SortType]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}          | [Used to select the sort type for sorting the grid data.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}                                                                      | [SortType]{style="COLOR: #2b91af"}                                                         | [SortType]{style="COLOR: #2b91af"}.Menu                                                          | [Dependent on AllowSorting]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}  |
|                                                                                 |                                                                                                                                                                                            |                                                                                            |                                                                                                  |                                                                                          |
|                                                                                 |                                                                                                                                                                                            |                                                                                            | [SortType]{style="COLOR: #2b91af"}.Normal                                                        |                                                                                          |
+---------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------+--------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------------------+
:::

 

Methods

  ----------------------------------------------------------------------------- ---------------------------------------------------------------------------------- ----------- ---------------
  Name                                                                          Description                                                                        Parameter   Return Type
  [EnableSorting]{style="FONT-WEIGHT: normal"}[]{style="FONT-WEIGHT: normal"}   [Used to enable the sorting property for the Grid.]{style="FONT-WEIGHT: normal"}   No          True or False
  ----------------------------------------------------------------------------- ---------------------------------------------------------------------------------- ----------- ---------------

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=325040fb-eeba-43e1-a434-e87058839b53){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=4ba4b1fb-6033-4ab0-a153-3370369db82f){style="TEXT-DECORATION: none"}
:::::
