::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=de0a853a-25b9-4fe8-b285-4625378c8883){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c4989e9a-ca5f-4ba5-8638-b8c5518361b4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grouping](ms-xhelp:///?Id=de0a853a-25b9-4fe8-b285-4625378c8883){.d2h_breadcrumbsNormal}
:::

### Server Mode {#server-mode style="tab-stops: 0pt"}

Grouping is defined as the act or process of consolidating grid data into groups. Grouping allows the categorization of records based on specified columns. You can easily group by a particular column by simply dragging the column to the upper portion of the grid. The grid data is automatically grouped when you drop a particular column. You are also able to expand a grouped record by clicking the ![](ImagesExt/image58_132.jpg){border="0"} icon beside the grouped record.

The Grid control has the following properties and methods which enable and control the grouping feature.

Properties

 

::: {align="center"}
+------------------+----------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| Property         | Description                                                                      | Type of property | Value it accepts | Any other dependencies/sub-properties associated |
+------------------+----------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| AllowGrouping    | Enables the grouping feature.                                                    | bool             | True/False       | NA                                               |
|                  |                                                                                  |                  |                  |                                                  |
|                  | Default value is False.                                                          |                  |                  |                                                  |
+------------------+----------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
| GroupDescriptors | Collection that is used to add grouped columns programmatically at initial load. | List\<string\>   |                  | Dependent on AllowGrouping.                      |
|                  |                                                                                  |                  |                  |                                                  |
|                  |                                                                                  |                  |                  |                                                  |
+------------------+----------------------------------------------------------------------------------+------------------+------------------+--------------------------------------------------+
:::

 

Methods

 

::: {align="center"}
  ---------------------------------------- --------------------------------- ----------------------- ------------------------------------------------------------------------------
  Method                                   Parameters                        Return type             Descriptions
  EnableGrouping()                         No parameter                      IGridBuilder\<T\>       Used to enable the grouping feature in the Grid control.
  AllowGrouping(bool)                      Enable as bool                    IGroupingBuilder\<T\>   Used to enable/disable the grouping feature.
  Groups (Action\<IGroupingBuilder\<T\>)   Action\<IGroupingBuilder\<T\>\>   IGroupingBuilder\<T\>   Used to add the grouped columns collection programmatically at initial load.
  ---------------------------------------- --------------------------------- ----------------------- ------------------------------------------------------------------------------
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through GridBuilder](ms-xhelp:///?Id=b81276e7-f18f-43d6-b386-8cd8f2698631){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through GridPropertiesModel](ms-xhelp:///?Id=e45f93ad-9908-4b26-97ba-76d017d90aa9){style="TEXT-DECORATION: none"}
::::::
