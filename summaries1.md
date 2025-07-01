::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d7d6e9e3-118a-4854-b3f2-083695e4d444){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=46c13c25-7e4b-4d96-828d-c83cc63dd61d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}
:::

## Summaries {#summaries style="tab-stops: 0pt"}

 

The Grid control allows you to display summaries. Summaries let you derive additional information from your data like averages, maximums, summations, counts, and more.

For instance, you can get the number of records or maximum value and so on. They display the calculation results in separate display rows. The summary values are calculated using **Linq** expressions.

The Grid control provides the following built-in summary types.

[·      ]{style="FONT-FAMILY: Symbol"}Int32Aggregate, DoubleAggregate (Average, Minimum, Maximum, Sum)

[·      ]{style="FONT-FAMILY: Symbol"}BooleanAggregate (Count, FalseCount, TrueCount)

[·      ]{style="FONT-FAMILY: Symbol"}Count

 

Summary Rows

 

The **GridPropertiesModel.SummaryRows** manages the collection of summary rows for the grid. It is the **GridSummaryRowDescriptorCollection** that manages the summaries for the given data source containing one entry for each summary. Each **GridSummaryRowDescriptor** in this collection has a name that identifies the **SummaryRowDescriptors** for which summaries are calculated for and a **SummaryType** property that defines the type of calculations to be performed. Possible options for **SummaryType** are: **Count**, **BooleanAggregate**, **Int32Aggregate**, **DoubleAggregate**.

 

Properties

 

::: {align="center"}
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| Property       | Description                                                                                                                     | Type of property                      | Value it accepts               | Any other dependencies/sub-properties associated |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| AllowSummaries | Used to enable or disable the summary feature.                                                                                  | bool                                  | True/False                     | NA                                               |
|                |                                                                                                                                 |                                       |                                |                                                  |
|                | Default value is False.                                                                                                         |                                       |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| SummaryRows    | A collection from GridSummaryRwoDecriptor that declares summary rows each with a multiple GridSummaryColumnDescriptor elements. | GridSummaryRowDescriptorCollection    |                                | Dependent with AllowSummaries.                   |
|                |                                                                                                                                 |                                       |                                |                                                  |
|                |                                                                                                                                 |                                       |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| Name           | Name used to identify in the Summary collection.                                                                                |                                       |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| SummaryType    | Specify the build-in summary type for SummaryColumnDescriptor.                                                                  | Enum                                  | SummaryType .Int32Aggregate,   |                                                  |
|                |                                                                                                                                 |                                       |                                |                                                  |
|                |                                                                                                                                 |                                       | SummaryType .DoubleAggregate,  |                                                  |
|                |                                                                                                                                 |                                       |                                |                                                  |
|                |                                                                                                                                 |                                       | SummaryType .BooleanAggregate, |                                                  |
|                |                                                                                                                                 |                                       |                                |                                                  |
|                |                                                                                                                                 |                                       | SummaryType .Count             |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| DataMember     | Specifies summary column used to perform the summary calculation.                                                               | string                                |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| Format         | Indicates the format for the text applied on the column.                                                                        | string                                |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| Prefix         | Specifies the text displayed before the summary column value.                                                                   | string                                |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| Suffix         | Indicates the text displayed after the summary column value.                                                                    | string                                |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| DisplayColumn  | Gets or sets the target column at which to display the summary.                                                                 | string                                |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| Title          | Specifies the text displayed on the summary row.                                                                                | string                                |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
| SummaryColumns | Used to add summary columns in the Summary row.                                                                                 | GridSummaryColumnDescriptorCollection |                                |                                                  |
|                |                                                                                                                                 |                                       |                                |                                                  |
|                |                                                                                                                                 |                                       |                                |                                                  |
+----------------+---------------------------------------------------------------------------------------------------------------------------------+---------------------------------------+--------------------------------+--------------------------------------------------+
:::

 

Methods

 

 

::: {align="center"}
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Method                                                             | Parameters                            | Class                                 | Return type | Description                                                                                                                |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Add(GridSummaryColumnDescriptor value)                             | GridSummaryColumnDescriptor           | GridSummaryColumnDescriptorCollection | Int         | Adds GridSummaryColumnDescriptor to the end of the collection.                                                             |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| AddRange(GridSummaryColumnDescriptor\[\] summaryColumnDescriptors) | Array of GridSummaryColumnDescriptors | GridSummaryColumnDescriptorCollection | Void        | Adds multiple GridSummaryColumnDescriptor at the end of the collection.                                                    |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Clear()                                                            | No parameter                          | GridSummaryColumnDescriptorCollection | Void        | Removes all GridSummaryColumnDescriptor from the collection.                                                               |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Contains(GridSummaryColumnDescriptor value)                        | GridSummaryColumnDescriptor           | GridSummaryColumnDescriptorCollection | bool        | Determines if the GridSummaryColumnDescriptor belongs to this Collection.                                                  |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Contains(string name)                                              | Name of the SummaryColumnDescriptor   |                                       | bool        | Determines if the GridSummaryColumnDescriptor with the specified name belongs to this Collection.                          |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       | GridSummaryColumnDescriptorCollection |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| IndexOf(GridSummaryColumnDescriptor value)                         | GridSummaryColumnDescriptor           | GridSummaryColumnDescriptorCollection | int         | Returns the zero-based index of the occurrence of the GridSummaryColumnDescriptor in the collection                        |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| IndexOf(string name)                                               | Name of the SummaryColumnDescriptor   | GridSummaryColumnDescriptorCollection | int         | Returns the zero-based index of the occurrence of the GridSummaryColumnDescriptor that matches the name in the collection. |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Insert(int index, GridSummaryColumnDescriptor value)               | Index, GridSummaryColumnDescriptor    | GridSummaryColumnDescriptorCollection | void        | Inserts a descriptor element into the collection at the specified index.                                                   |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Remove(GridSummaryColumnDescriptor value)                          | GridSummaryColumnDescriptor           | GridSummaryColumnDescriptorCollection | void        | Removes the specified GridSummaryColumnDescriptor from the collection.                                                     |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| RemoveAt(int index)                                                | Index                                 | GridSummaryColumnDescriptorCollection | void        | Removes the GridSummaryColumnDescriptor that matches the specified name from the collection.                               |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Add(GridSummaryRowDescriptor value)                                | GridSummaryRowDescriptor              | GridSummaryRowDescriptorCollection    | int         | Adds GridSummaryRowDescriptor to the end of the collection.                                                                |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Clear()                                                            | No Parameter                          | GridSummaryRowDescriptorCollection    | void        | Removes all GridSummaryRowDescriptor from the collection.                                                                  |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Contains(GridSummaryRowDescriptor value)                           | GridSummaryRowDescriptor              | GridSummaryRowDescriptorCollection    | bool        | Determines if the GridSummaryRowDescriptor belongs to this Collection.                                                     |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Contains(string name)                                              | Name of the SummaryRowDescriptor      | GridSummaryRowDescriptorCollection    | bool        | Determines if the GridSummaryRowDescriptor with the specified name belongs to this Collection.                             |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| IndexOf(GridSummaryRowDescriptor value)                            | GridSummaryRowDescriptor              | GridSummaryRowDescriptorCollection    | int         | Returns the zero-based index of the occurrence of the GridSummaryRowDescriptor in the collection.                          |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| IndexOf(string name)                                               | Name of the SummaryRowDescriptor      | GridSummaryRowDescriptorCollection    | int         | Returns the zero-based index of the occurrence of the GridSummaryRowDescriptor that matches the name in the collection.    |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Insert(int index, GridSummaryRowDescriptor value)                  | Index, GridSummaryRowDescriptor       | GridSummaryRowDescriptorCollection    | void        | Inserts a descriptor GridSummaryRowDescriptor into the collection at the specified index.                                  |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Remove(GridSummaryRowDescriptor value)                             | GridSummaryRowDescriptor              | GridSummaryRowDescriptorCollection    | void        | Removes the specified GridSummaryRowDescriptor from the collection.                                                        |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| Remove(string name)                                                | Name of the GridSummaryRowDescriptor  | GridSummaryRowDescriptorCollection    | void        | Removes the specified GridSummaryRowDescriptor from the collection that matches the name.                                  |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
| RemoveAt(int index)                                                | Index                                 | GridSummaryRowDescriptorCollection    | void        | Removes the GridSummaryRowDescriptor that matches the specified name from the collection.                                  |
|                                                                    |                                       |                                       |             |                                                                                                                            |
|                                                                    |                                       |                                       |             |                                                                                                                            |
+--------------------------------------------------------------------+---------------------------------------+---------------------------------------+-------------+----------------------------------------------------------------------------------------------------------------------------+
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=46c13c25-7e4b-4d96-828d-c83cc63dd61d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=d3c11ff4-805f-44aa-9998-875c4aab1043){style="TEXT-DECORATION: none"}
::::::
