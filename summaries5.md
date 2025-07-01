::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Summaries {#summaries style="tab-stops: 0pt"}

GridDataControl provides support to add additional rows at the bottom of the grid table. Such rows are fixed and are used to brief information about the grid data, called Summaries. For instance, you can display the record count or maximum value as summary.

 

The following are the built-in summary types supported by grid. They are otherwise called as basic summaries.

 

[·      ]{style="FONT-FAMILY: Symbol"}CountAggregate

[·      ]{style="FONT-FAMILY: Symbol"}Int32Aggregate

[·      ]{style="FONT-FAMILY: Symbol"}DoubleAggregate

[·      ]{style="FONT-FAMILY: Symbol"}CustomAggregate (used with custom summaries)

**[]{style="COLOR: #15428b"}** 

SummaryRows Collection

 

Grid provides three kinds of SummaryRows collections -- SummaryRows, TableSummaryRows and CaptionSummaryRows, in order to separate the summary kinds. This collection stores all the summaries for a given grid, in which each entry corresponds to a summary row holding the various summary details such as summary title, summary style, its visibility, and more importantly the SummaryColumns collection.

 

SummaryColumns Collection

 

Every summary row contains a corresponding SummaryColumns collection. This collection stores the group of columns whose values are used for the summary calculation. As this is a collection of columns, you could infer that summaries can be calculated from more than one column. This collection explores the properties that are essential for generating summary information. The following are some of the properties that are used to generate the summary information.

 

[·      ]{style="FONT-FAMILY: Symbol"}MappingName: mapping name of the column used

[·      ]{style="FONT-FAMILY: Symbol"}Format: summary format, for example, \"{SUM=##.00}\"

[·      ]{style="FONT-FAMILY: Symbol"}SummaryType: built-in summary type

 

This section comprises the following topics:

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating Summaries](ms-xhelp:///?Id=b4b9cd3a-6c0b-4876-b6e6-b066f6d6c70e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Summary Types](ms-xhelp:///?Id=408cfe98-9bf9-47d5-bac6-3c1605fcc130){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Custom Summaries](ms-xhelp:///?Id=372599ce-f4d3-45d8-9214-875e8904ce13){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Summary Style](ms-xhelp:///?Id=853cf8af-e654-40dc-89c1-15c8e5f30592){style="TEXT-DECORATION: none"}
:::
