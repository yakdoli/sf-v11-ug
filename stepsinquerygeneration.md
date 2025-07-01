::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=0baccd40-5f39-46c3-8e55-a3c199068568){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=86caec87-83c5-41b2-9ab3-59a33858fc49){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[QueryBuilderEngine](ms-xhelp:///?Id=355fc08c-4d81-4bea-8a8c-9a957615e282){.d2h_breadcrumbsNormal}
:::

### Steps in Query Generation {#steps-in-query-generation style="tab-stops: 0pt"}

To generate a query:

1.   Get the query specification and iterate through the items in each category (With, Select and Where) of specification and separately store the column elements, row elements, filter elements and slice elements.

2.   The filter, slicer and sort elements are moved to the appropriate axis based on their axis property.

3.   Once the initial level categorizing of elements is completed, it starts creating a query string by writing using **With** or **Select**.

4.   Now it starts writing the query by checking each and every property.

 

By invoking the **BuildAxisElements()** method, the building query for the column axis elements and row axis elements are done.

The helper methods for the **BuildAxisElements()** are:

[·      ]{style="FONT-FAMILY: Symbol"}BuildAxisItems

[·      ]{style="FONT-FAMILY: Symbol"}BuildDimensionElement

[·      ]{style="FONT-FAMILY: Symbol"}If no level is specified, the  **GetDefaultLevel()** method will be called else

[·      ]{style="FONT-FAMILY: Symbol"}The **BuildHierarchyElement()** will be called

[·      ]{style="FONT-FAMILY: Symbol"}BuildLevelElements

[·      ]{style="FONT-FAMILY: Symbol"}If the level member count is greater than zero the **BuildMemberElement()** will be called else the **GetDefaultLevel()** method will be called.

The **BuildAxisElements()** will build the query for the column element when we pass the column items and it will generate the query for the row elements when the row items is passed as an argument. The **BuildAxisElements()** method will return a Boolean value which represents whether the KPI element is existing in the given item list or not. Based on that return, the value of the KPI Element axis was fixed.

Up to this the **Select** section of the query was built and now the **From** section. The **From** section will start by invoking the **BuildFiltereCondition**() method.

The Helper method for the **BuildFiltereCondition()** is given below:

1.   **BuildFilteredElements()** - This method iterates through the elements and appends the parent details and child member details in the query based on the axis either in a row or in a column.

2.   Then it comes to the **Where** section, by invoking the **BuildSlicerElements**() method.

3.   Then the **BuildSlicerItem** is invoked. This method will check whether the given item is Dimension or Measure or KPI or NamedSet or Level and based on this the appropriate query part will appended with the query.

 

Finally, the Cell properties will append with the created query and the query string will be returned to the **OlapDataManager**. By using the newly generated query, the OlapDataManager will invoke the **ExecuteCellSet** of **DataProvide**, which will return the **CellSet**.

This **CellSet** will be used to create the **PivotEngine**, which will give the input to the controls.

 

[]{#related-topics}
::::
