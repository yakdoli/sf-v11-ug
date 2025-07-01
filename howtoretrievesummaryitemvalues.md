::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=37997c34-f0d3-4ec1-ab1c-de7671e2ab2f){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e53ade87-b7fb-4662-92cb-d05c26425b5f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grouping](ms-xhelp:///?Id=37faf36d-c8f0-4c7d-90e1-39deecb620a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bfb16001-cfb0-4acb-bfb4-64f7d21463fd){.d2h_breadcrumbsNormal}
:::

## How to Retrieve Summary Item Values? {#how-to-retrieve-summary-item-values style="tab-stops: 0pt"}

 

Summaries are calculated on groups of records. The **TopLevelGroup** is the collection of all records in the **IList** data source. If you have added additional grouping through the **groupingEngine.TableDescriptor.GroupedColumns.Add**, then in addition to the top level group, there will be additional groups available to you. Each group will have an associated summary value. So to retrieve a summary value, you need to specify the group associated with the summary.

 

For example, the code below assumes that you have grouped the table on field \"C\" and are looking for the summary associated with the group whose records have field \"C\" equal to the value \"c1\". It also shows the same summary value for the TopLevelGroup**.**

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [// To simplify notation, set this using the statement at the top of your code file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                                                                                   |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ISummary]{style="COLOR: teal"} = Syncfusion.Collections.BinaryTree.[ITreeTableSummary]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                                                   |
| [     ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                   |
| [// Now get the Summary value for the TopLevelGroup group.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                     |
|                                                                                                                                                                                                                                   |
| [ISummary]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ groupSummary = groupingEngine.Table.TopLevelGroup.GetSummary([\"BInt32Agg\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                                   |
| [Int32AggregateSummary]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ int32Summary = ([Int32AggregateSummary]{style="COLOR: teal"}) groupSummary;]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.WriteLine([\"whole table {0}, {1}, {2}\"]{style="COLOR: maroon"}, int32Summary.Sum, int32Summary.Average, int32Summary.Maximum);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| [        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                   |
| [// Value for \"c1\" group.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                    |
|                                                                                                                                                                                                                                   |
| [groupSummary = groupingEngine.Table.TopLevelGroup.Groups\[[\"c1\"]{style="COLOR: maroon"}\].GetSummary([\"BInt32Agg\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                                                   |
| [int32Summary = ([Int32AggregateSummary]{style="COLOR: teal"}) groupSummary;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.WriteLine([\"c1-group {0}, {1}, {2}\"]{style="COLOR: maroon"}, int32Summary.Sum, int32Summary.Average, int32Summary.Maximum);]{style="FONT-FAMILY: 'Courier New'"}    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                            |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                               |
| [\' To simplify notation, set this using the statement at the top of your code file.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                                                                               |
| [Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [\' Now get the Summary value for the TopLevelGroup group.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ groupSummary [As]{style="COLOR: blue"} ISummary = groupingEngine.Table.TopLevelGroup.GetSummary([\"BInt32Agg\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ int32Summary [As]{style="COLOR: blue"} Int32AggregateSummary = [CType]{style="COLOR: blue"}(groupSummary, Int32AggregateSummary)]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [Console.WriteLine([\"whole table {0}, {1}, {2}\"]{style="COLOR: maroon"}, int32Summary.Sum, int32Summary.Average, int32Summary.Maximum)]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [\' Value for \"c1\" group.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ groupSummary = groupingEngine.Table.TopLevelGroup.Groups([\"c1\"]{style="COLOR: maroon"}).GetSummary([\"BInt32Agg\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ int32Summary = [CType]{style="COLOR: blue"}(groupSummary, Int32AggregateSummary)]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [Console.WriteLine([\"c1-group {0}, {1}, {2}\"]{style="COLOR: maroon"}, int32Summary.Sum, int32Summary.Average, int32Summary.Maximum)]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
