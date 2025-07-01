::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Summaries {#summaries style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

GridDataControl provides support to add additional rows at the bottom of the grid table. Such rows are fixed and are used to brief information about the grid data, called **Summaries**. For instance, you can display the record count or maximum value as summary.

 

The following are the built-in summary types supported by grid. They are otherwise called as basic summaries.

 

[·      ]{style="FONT-FAMILY: Symbol"}CountAggregate

[·      ]{style="FONT-FAMILY: Symbol"}Int32Aggregate

[·      ]{style="FONT-FAMILY: Symbol"}DoubleAggregate

[·      ]{style="FONT-FAMILY: Symbol"}CustomAggregate (used with custom summaries)

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

SummaryRows Collection

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Grid provides three kinds of SummaryRows collections -- **SummaryRows**, **TableSummaryRows** and **CaptionSummaryRows**, in order to separate the summary kinds. This collection stores all the summaries for a given grid, in which each entry corresponds to a summary row holding the various summary details such as summary title, summary style, its visibility, and more importantly the SummaryColumns collection.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

SummaryColumns Collection

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Every summary row contains a corresponding **SummaryColumns** collection. This collection stores the group of columns whose values are used for the summary calculation. As this is a collection of columns, you could infer that summaries can be calculated from more than one column. This collection explores the properties that are essential for generating summary information. The following are some of the properties that are used to generate the summary information.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**MappingName**: mapping name of the column used

[·      ]{style="FONT-FAMILY: Symbol"}**Format**: summary format, for example, \"{SUM=##.00}\"

[·      ]{style="FONT-FAMILY: Symbol"}**SummaryType**: built-in summary type

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This section comprises the following topics:

[]{#p248} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating Summaries](ms-xhelp:///?Id=a2ef4fc0-bd69-4719-963f-0b5bf4a8278e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Summary Types](ms-xhelp:///?Id=df1a1eaf-c7ee-4eb2-836d-2f12a759db77){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Custom Summaries](ms-xhelp:///?Id=be21d748-0ffb-47f4-a0f2-bb1295299353){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Summary Style](ms-xhelp:///?Id=6728ae11-1b33-4a89-9ae6-15fa48601f7d){style="TEXT-DECORATION: none"}
:::
