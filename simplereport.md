::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Simple Report {#simple-report style="tab-stops: 0pt"}

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]                                                  ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                     |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                        |
| [OlapReport]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ olapReport = [new]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                        |
| [olapReport.Name = [\"Customer Report\"]{style="COLOR: #a31515"};\                                                                                                                     |
| olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"};\                                                                                                           |
|  \                                                                                                                                                                                     |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementColumn = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                                          |
| [//Specifying the Name for the Dimension Element]{style="COLOR: green"}\                                                                                                               |
| dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"};\                                                                                                                 |
| dimensionElementColumn.HierarchyName = [\"Customer Geography\"]{style="COLOR: #a31515"};\                                                                                              |
| dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});\                                                             |
|  \                                                                                                                                                                                     |
| [MeasureElements]{style="COLOR: #2b91af"} measureElementColumn = [new]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"}();\                                              |
| measureElementColumn.Elements.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Internet Sales Amount\"]{style="COLOR: #a31515"} });\                |
|  \                                                                                                                                                                                     |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementRow = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                                             |
| [//Specifying the Dimension Name]{style="COLOR: green"}\                                                                                                                               |
| dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"};\                                                                                                                        |
| dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});\                                                                        |
|  \                                                                                                                                                                                     |
| [///]{style="COLOR: gray"}[ Adding Column Members]{style="COLOR: green"}\                                                                                                              |
| olapReport.CategoricalElements.Add(dimensionElementColumn);\                                                                                                                           |
| [///]{style="COLOR: gray"}[Adding Measure Element]{style="COLOR: green"}\                                                                                                              |
| olapReport.CategoricalElements.Add(measureElementColumn);\                                                                                                                             |
| [///]{style="COLOR: gray"}[Adding Row Members]{style="COLOR: green"}\                                                                                                                  |
| olapReport.SeriesElements.Add(dimensionElementRow);]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                              |
|                                                                                                                                                                                                               |
| [\                                                                                                                                                                                                            |
| [Dim]{style="COLOR: blue"} olapReport [As]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"} = [New]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [olapReport.Name = [\"Customer Report\"]{style="COLOR: #a31515"}\                                                                                                                                             |
| olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"}\                                                                                                                                   |
|  \                                                                                                                                                                                                            |
| [Dim]{style="COLOR: blue"} dimensionElementColumn [As]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"} = [New]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}()\             |
| [\'Specifying the Name for the Dimension Element]{style="COLOR: green"}\                                                                                                                                      |
| dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"}\                                                                                                                                         |
| dimensionElementColumn.HierarchyName = [\"Customer Geography\"]{style="COLOR: #a31515"}\                                                                                                                      |
| dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"})\                                                                                     |
|  \                                                                                                                                                                                                            |
| [Dim]{style="COLOR: blue"} measureElementColumn [As]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"} = [New]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"}()\                 |
| measureElementColumn.Elements.Add([New]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} [With]{style="COLOR: blue"} {.Name = [\"Internet Sales Amount\"]{style="COLOR: #a31515"}})\             |
|  \                                                                                                                                                                                                            |
| [Dim]{style="COLOR: blue"} dimensionElementRow [As]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"} = [New]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}()\                |
| [\'Specifying the Dimension Name]{style="COLOR: green"}\                                                                                                                                                      |
| dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"}\                                                                                                                                                |
| dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"})\                                                                                                |
|  \                                                                                                                                                                                                            |
| [\'\'\' Adding Column Members]{style="COLOR: green"}\                                                                                                                                                         |
| olapReport.CategoricalElements.Add(dimensionElementColumn)\                                                                                                                                                   |
| [\'\'\'Adding Measure Element]{style="COLOR: green"}\                                                                                                                                                         |
| olapReport.CategoricalElements.Add(measureElementColumn)\                                                                                                                                                     |
| [\'\'\'Adding Row Members]{style="COLOR: green"}\                                                                                                                                                             |
| olapReport.SeriesElements.Add(dimensionElementRow)]{style="FONT-FAMILY: 'Courier New'"}[   ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
