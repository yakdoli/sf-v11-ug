::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### PivotItem {#pivotitem style="tab-stops: 0pt"}

 

A pivot item is an item in a PivotTable field. PivotItem provides the information needed to define a pivot item for either a row or column pivot. It consists of the following fields.

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
| TotalHeader      | Gets or sets the string you want appended to the pivot item\'s summary cells.                                                                                  | string      | \-               | \-             |
+------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+------------------+----------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Defining PivotItem in XAML and Code-Behind](ms-xhelp:///?Id=89fc0901-0d8f-4314-a5a5-4c61cc295067){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Sorting Using PivotItem](ms-xhelp:///?Id=57f1a7d5-32ed-4393-af91-b4361bf493bc){style="TEXT-DECORATION: none"}
:::
