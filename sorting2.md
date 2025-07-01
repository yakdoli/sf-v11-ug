::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8ce07526-d42f-4487-b4de-814b941fd037){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=543bb891-c96b-4876-92f9-2df3ca4c989e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}
:::

## Sorting {#sorting style="tab-stops: 0pt"}

Sorting is defined as the process of arranging items/records in some ordered sequence. Essential Grid supports arranging table data in ascending (![Description: http://help.syncfusion.com/ug_82/ASP.NETMVCUI_Grid/Images/sortup.gif](ImagesExt/image58_112.gif){border="0"}) or descending (![Description: http://help.syncfusion.com/ug_82/ASP.NETMVCUI_Grid/Images/sortdown.gif](ImagesExt/image58_113.gif){border="0"}) order based on the column header that is clicked. The order switches between ascending and descending each time you click a column header for sorting.

 

Multi-sorting is enabled by setting the **AllowMultiSorting** property to **True**. It can also be performed by holding CTRL and clicking the respective column headers.

The Grid control has the following properties and methods to enable sorting.

 

Properties

 

::: {align="center"}
+----------------------+-------------------------------------------------------------------------------------------------------+-------------------------+------------------+--------------------------------------------------+
| Property             | Description                                                                                           | Type of property        | Value it accepts | Any other dependencies/sub-properties associated |
+----------------------+-------------------------------------------------------------------------------------------------------+-------------------------+------------------+--------------------------------------------------+
| AllowSorting         | Enables the sorting feature. Default value is False.                                                  | bool                    | True/False       | NA                                               |
+----------------------+-------------------------------------------------------------------------------------------------------+-------------------------+------------------+--------------------------------------------------+
| SortDescriptors      | Collection that is used to add sorted columns programmatically at initial load with sort directions.  | IList\<SortDescriptor\> |                  | Dependent on AllowSorting.                       |
|                      |                                                                                                       |                         |                  |                                                  |
|                      |                                                                                                       |                         |                  |                                                  |
+----------------------+-------------------------------------------------------------------------------------------------------+-------------------------+------------------+--------------------------------------------------+
| AllowMultiSorting    | Enables multicolumn sorting. Setting the value to true, will allow the user to sort multiple columns. | bool                    | True/False       | Dependent on AllowSorting.                       |
|                      |                                                                                                       |                         |                  |                                                  |
|                      | Default value is False.                                                                               |                         |                  |                                                  |
+----------------------+-------------------------------------------------------------------------------------------------------+-------------------------+------------------+--------------------------------------------------+
| DisableSortedColumns | Collection that is used to disable the sorting for individual columns.                                | List\<string\>          |                  | Dependent on AllowSorting.                       |
+----------------------+-------------------------------------------------------------------------------------------------------+-------------------------+------------------+--------------------------------------------------+
:::

 

::: {align="center"}
+----------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+-----------------+----------------------+
| Methods                                                  | Description                                                                                                  | Parameters      | Return type          |
+----------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+-----------------+----------------------+
| EnableSorting()                                          | Used to enable the sorting feature in Grid control.                                                          | No parameter    | IGridBuilder\<T\>    |
+----------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+-----------------+----------------------+
| AllowSorting(bool)                                       | Used to enable/disable the sorting feature.                                                                  | Enable as bool  | ISortingBuilder\<T\> |
+----------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+-----------------+----------------------+
| AllowMultiSorting (bool)                                 | Used to enable multicolumn sorting. Setting the value to true, will allow the user to sort multiple columns. | Enable as bool  | ISortingBuilder\<T\> |
+----------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+-----------------+----------------------+
| SortDescriptors(Action\<IGridSortingColumnBuilder\<T\>\> | Used to add sorted column collections programmatically at initial load with sort directions.                 | Action method   | ISortingBuilder\<T\> |
|                                                          |                                                                                                              |                 |                      |
|                                                          |                                                                                                              |                 |                      |
+----------------------------------------------------------+--------------------------------------------------------------------------------------------------------------+-----------------+----------------------+
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=543bb891-c96b-4876-92f9-2df3ca4c989e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=8f935683-630f-4af3-a0a3-b6bebf4bdb83){style="TEXT-DECORATION: none"}
::::::
