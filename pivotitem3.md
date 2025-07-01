::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4c7c53bf-fd09-4600-aaf4-4f09cc0f9359){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=70ddf0f1-88c8-45f4-a598-f0b870201a3b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Windows](ms-xhelp:///?Id=af2b5ead-c104-4cdd-b5e2-2b2aee61afe3){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4c7c53bf-fd09-4600-aaf4-4f09cc0f9359){.d2h_breadcrumbsNormal}
:::

## PivotItem {#pivotitem style="tab-stops: 0pt"}

PivotItem is an item in a PivotTable field. It provides the information needed to define a pivot item for either a row or column. It consists of the following fields.

Table 5: Properties Table for PivotItem

+------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+------------------+----------------+
|                  |                                                                                                                                                                |             |                  |                |
|                  |                                                                                                                                                                |             |                  |                |
| Property Name    | Description                                                                                                                                                    | Type        | Value it Accepts | Reference link |
|                  |                                                                                                                                                                |             |                  |                |
|                  |                                                                                                                                                                |             |                  |                |
+==================+================================================================================================================================================================+=============+==================+================+
| Comparer         | Gets or sets the IComparer object used for sorting. If this value is null, then sorting will be performed under the assumption that this field is IComparable. | IComparer   | \-               | \-             |
+------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+------------------+----------------+
| FieldHeader      | Gets or sets the title you want to see in the header for this pivot item.                                                                                      | string      | \-               | \-             |
+------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+------------------+----------------+
| FieldMappingName | Gets or sets the property\'s mapping name.                                                                                                                     | string      | \-               | \-             |
+------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+------------------+----------------+
| Format           | Gets or sets the format item for the specified field.                                                                                                          | string      | \-               | \-             |
+------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+------------------+----------------+
| TotalHeader      | Gets or sets the string you want to append to the pivot item\'s summary cells.                                                                                 | string      | \-               | \-             |
+------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+------------------+----------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Defining PivotItem in Code-Behind](ms-xhelp:///?Id=70ddf0f1-88c8-45f4-a598-f0b870201a3b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Sorting Using PivotItem](ms-xhelp:///?Id=3a734f20-3843-483b-bf18-0604f13f8e8d){style="TEXT-DECORATION: none"}
::::
