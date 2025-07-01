::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Report with Filter {#report-with-filter style="tab-stops: 0pt"}

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                               |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [OlapReport]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ olapReport = [new]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                |
| [olapReport.Name = [\"Customer Report\"]{style="COLOR: #a31515"};\                                                                                                                                             |
| olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"};\                                                                                                                                   |
|  \                                                                                                                                                                                                             |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementColumn = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                                                                  |
| [//Specifying the Name for the Dimension Element]{style="COLOR: green"}\                                                                                                                                       |
| dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"};\                                                                                                                                         |
| dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});\                                                                                     |
|  \                                                                                                                                                                                                             |
| [//Creating Measure Element]{style="COLOR: green"}\                                                                                                                                                            |
| [MeasureElements]{style="COLOR: #2b91af"} measureElementColumn = [new]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"}();\                                                                      |
| measureElementColumn.Elements.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name =                                        [\"Internet Sales Amount\"]{style="COLOR: #a31515"} });\ |
|  \                                                                                                                                                                                                             |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementRow = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                                                                     |
| [//Specifying the Dimension Name]{style="COLOR: green"}\                                                                                                                                                       |
| dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"};\                                                                                                                                                |
| dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});\                                                                                                |
|  \                                                                                                                                                                                                             |
| [FilterElement]{style="COLOR: #2b91af"} filterElement = [new]{style="COLOR: blue"} [FilterElement]{style="COLOR: #2b91af"}([AxisPosition]{style="COLOR: #2b91af"}.Categorical);\                               |
| filterElement.Elements.Add(measureElementColumn);\                                                                                                                                                             |
| filterElement.Elements.Add(dimensionElementColumn);\                                                                                                                                                           |
| filterElement.FilterCase = [FilterCase]{style="COLOR: #2b91af"}.GreaterThan;\                                                                                                                                  |
| filterElement.FilterValue.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = ]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                |
| [                                  [\"Internet Sales Amount\"]{style="COLOR: #a31515"}, Visible = [true]{style="COLOR: blue"} });\                                                                             |
| filterElement.FilterValue.Add([new]{style="COLOR: blue"} [FilterValue]{style="COLOR: #2b91af"} { Filter_Value = 2700000.00 });\                                                                                |
| filterElement.IsFilterCondition = [true]{style="COLOR: blue"};\                                                                                                                                                |
| [///]{style="COLOR: gray"}[ Adding Column Members]{style="COLOR: green"}\                                                                                                                                      |
| olapReport.CategoricalElements.Add([new]{style="COLOR: blue"} [Item]{style="COLOR: #2b91af"} { ElementValue = ]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                |
| [dimensionElementColumn });\                                                                                                                                                                                   |
| olapReport.CategoricalElements.IsFilterOrSortOn = [true]{style="COLOR: blue"};\                                                                                                                                |
| olapReport.FilterElements.Add([new]{style="COLOR: blue"} [Item]{style="COLOR: #2b91af"} { ElementValue = filterElement });\                                                                                    |
|  \                                                                                                                                                                                                             |
| olapReport.SeriesElements.Add(dimensionElementRow);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                            |
|                                                                                                                                                                                                                             |
| [\                                                                                                                                                                                                                          |
| ]{style="FONT-FAMILY: 'Courier New'"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapReport [As]{style="COLOR: blue"} OlapReport = [New]{style="COLOR: blue"} OlapReport()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [olapReport.Name = [\"Customer Report\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                             |
| [olapReport.CurrentCubeName = \"Adventure Works\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementColumn [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                             |
| [\'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                             |
| [dimensionElementColumn.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                             |
| [dimensionElementColumn.AddLevel(\"Customer Geography\", \"Country\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'Creating Measure Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ measureElementColumn [As]{style="COLOR: blue"} MeasureElements = [New]{style="COLOR: blue"} MeasureElements()]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                             |
| [measureElementColumn.Elements.Add([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = \"Internet Sales Amount\"})]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementRow [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                                                             |
| [\'Specifying the Dimension Name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                             |
| [dimensionElementRow.Name = \"Date\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [dimensionElementRow.AddLevel(\"Fiscal\", \"Fiscal Year\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ filterElement [As]{style="COLOR: blue"} FilterElement = [New]{style="COLOR: blue"} FilterElement(AxisPosition.Categorical)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                             |
| [filterElement.Elements.Add(measureElementColumn)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [filterElement.Elements.Add(dimensionElementColumn)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [filterElement.FilterCase = FilterCase.GreaterThan]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [filterElement.FilterValue.Add([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = \"Internet Sales Amount\", .Visible = [True]{style="COLOR: blue"}})]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [filterElement.FilterValue.Add([New]{style="COLOR: blue"} FilterValue [With]{style="COLOR: blue"} {.Filter_Value = 2700000.00})]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                                             |
| [filterElement.IsFilterCondition = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                             |
| [olapReport.CategoricalElements.Add([New]{style="COLOR: blue"} Item [With]{style="COLOR: blue"} {.ElementValue = dimensionElementColumn})]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                             |
| [olapReport.CategoricalElements.IsFilterOrSortOn = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                             |
| [olapReport.FilterElements.Add([New]{style="COLOR: blue"} Item [With]{style="COLOR: blue"} {.ElementValue = filterElement})]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
