::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Report with dicing operation {#report-with-dicing-operation style="tab-stops: 0pt"}

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                        |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                         |
| [OlapReport]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ olapReport = [new]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"}();\                      |
| olapReport.Name = [\"Customer Report\"]{style="COLOR: #a31515"};\                                                                                                       |
| olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"};\                                                                                            |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementColumn = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                           |
| [//Specifying the Name for the Dimension Element]{style="COLOR: green"}\                                                                                                |
| dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"};\                                                                                                  |
| [//Specifying the Hierarchy Name]{style="COLOR: green"}\                                                                                                                |
| dimensionElementColumn.HierarchyName = [\"Customer Geography\"]{style="COLOR: #a31515"};\                                                                               |
| dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});\                                              |
|  \                                                                                                                                                                      |
| [MeasureElements]{style="COLOR: #2b91af"} measureElementColumn = [new]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"}();\                               |
| measureElementColumn.Elements.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Internet Sales Amount\"]{style="COLOR: #a31515"} });\ |
|  \                                                                                                                                                                      |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementRow = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                              |
| [//Specifying the Dimension Name]{style="COLOR: green"}\                                                                                                                |
| dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"};\                                                                                                         |
| dimensionElementRow.HierarchyName = [\"Fiscal\"]{style="COLOR: #a31515"};\                                                                                              |
| dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});\                                                         |
|  \                                                                                                                                                                      |
| [//Specifying Excluded column elements]{style="COLOR: green"}\                                                                                                          |
| [DimensionElement]{style="COLOR: #2b91af"} excludedColumnElement = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                            |
| excludedColumnElement.Name = [\"Customer\"]{style="COLOR: #a31515"};\                                                                                                   |
| excludedColumnElement.HierarchyName = [\"Customer Geography\"]{style="COLOR: #a31515"};\                                                                                |
| excludedColumnElement.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});\                                               |
| excludedColumnElement.Hierarchy.LevelElements\[[\"Country\"]{style="COLOR: #a31515"}\].Add([\"Canada\"]{style="COLOR: #a31515"});\                                      |
| excludedColumnElement.Hierarchy.LevelElements\[[\"Country\"]{style="COLOR: #a31515"}\].Add([\"France\"]{style="COLOR: #a31515"});\                                      |
| excludedColumnElement.Hierarchy.LevelElements\[[\"Country\"]{style="COLOR: #a31515"}\].Add([\"United Kingdom\"]{style="COLOR: #a31515"});\                              |
| excludedColumnElement.Hierarchy.LevelElements\[[\"Country\"]{style="COLOR: #a31515"}\].Add([\"United States\"]{style="COLOR: #a31515"});\                               |
|  \                                                                                                                                                                      |
|  \                                                                                                                                                                      |
| [//Spefifying the Excluded row elements]{style="COLOR: green"}\                                                                                                         |
| [DimensionElement]{style="COLOR: #2b91af"} excludedRowElement = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                               |
| excludedRowElement.Name = [\"Date\"]{style="COLOR: #a31515"};\                                                                                                          |
| excludedRowElement.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});\                                                          |
| excludedRowElement.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Month\"]{style="COLOR: #a31515"});\                                                                |
| excludedRowElement.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Quarter\"]{style="COLOR: #a31515"});\                                                       |
| excludedRowElement.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Semester\"]{style="COLOR: #a31515"});\                                                      |
| excludedRowElement.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].Add([\"FY 2002\"]{style="COLOR: #a31515"});\                                    |
| excludedRowElement.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].Add([\"FY 2004\"]{style="COLOR: #a31515"});\                                    |
| excludedRowElement.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].Add([\"FY 2005\"]{style="COLOR: #a31515"});\                                    |
| excludedRowElement.Hierarchy.LevelElements\[[\"Fiscal Semester\"]{style="COLOR: #a31515"}\].Add([\"H2 FY 2003\"]{style="COLOR: #a31515"});\                             |
| excludedRowElement.Hierarchy.LevelElements\[[\"Month\"]{style="COLOR: #a31515"}\].Add([\"August 2002\"]{style="COLOR: #a31515"});\                                      |
| excludedRowElement.Hierarchy.LevelElements\[[\"Month\"]{style="COLOR: #a31515"}\].Add([\"September 2002\"]{style="COLOR: #a31515"});\                                   |
| excludedRowElement.Hierarchy.LevelElements\[[\"Fiscal Quarter\"]{style="COLOR: #a31515"}\].Add([\"Q2 FY 2003\"]{style="COLOR: #a31515"});\                              |
| excludedRowElement.Hierarchy.LevelElements\[[\"Fiscal Quarter\"]{style="COLOR: #a31515"}\].Add([\"Q2 FY 2003\"]{style="COLOR: #a31515"});\                              |
|  \                                                                                                                                                                      |
| [///]{style="COLOR: gray"}[Adding Column Members]{style="COLOR: green"}\                                                                                                |
| olapReport.CategoricalElements.Add(dimensionElementColumn,excludedColumnElement);\                                                                                      |
| [///]{style="COLOR: gray"}[Adding Measure Element]{style="COLOR: green"}\                                                                                               |
| olapReport.CategoricalElements.Add(measureElementColumn);\                                                                                                              |
| [///]{style="COLOR: gray"}[Adding Row Members]{style="COLOR: green"}\                                                                                                   |
| olapReport.SeriesElements.Add(dimensionElementRow,excludedRowElement);]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

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
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementColumn [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                             |
| [\'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                             |
| [dimensionElementColumn.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                             |
| [\'Specifying the Hierarchy Name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                             |
| [dimensionElementColumn.HierarchyName = \"Customer Geography\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                             |
| [dimensionElementColumn.AddLevel(\"Customer Geography\", \"Country\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ measureElementColumn [As]{style="COLOR: blue"} MeasureElements = [New]{style="COLOR: blue"} MeasureElements()]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                             |
| [measureElementColumn.Elements.Add(New MeasureElement { Name = \"Internet Sales Amount\" });]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                       |
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
| [dimensionElementRow.HierarchyName = \"Fiscal\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [dimensionElementRow.AddLevel(\"Fiscal\", \"Fiscal Year\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'Specifying Excluded column elements]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ excludedColumnElement [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                                                             |
| [excludedColumnElement.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                             |
| [excludedColumnElement.HierarchyName = \"Customer Geography\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [excludedColumnElement.AddLevel(\"Customer Geography\", \"Country\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                             |
| [excludedColumnElement.Hierarchy.LevelElements(\"Country\").Add(\"Canada\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                             |
| [excludedColumnElement.Hierarchy.LevelElements(\"Country\").Add(\"France\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                             |
| [excludedColumnElement.Hierarchy.LevelElements(\"Country\").Add(\"United Kingdom\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                             |
| [excludedColumnElement.Hierarchy.LevelElements(\"Country\").Add(\"United States\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'Spefifying the Excluded row elements]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ excludedRowElement [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Name = \"Date\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [excludedRowElement.AddLevel(\"Fiscal\", \"Fiscal Year\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                             |
| [excludedRowElement.AddLevel(\"Fiscal\", \"Month\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [excludedRowElement.AddLevel(\"Fiscal\", \"Fiscal Quarter\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                             |
| [excludedRowElement.AddLevel(\"Fiscal\", \"Fiscal Semester\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Fiscal Year\").Add(\"FY 2002\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Fiscal Year\").Add(\"FY 2004\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Fiscal Year\").Add(\"FY 2005\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Fiscal Semester\").Add(\"H2 FY 2003\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Month\").Add(\"August 2002\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Month\").Add(\"September 2002\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Fiscal Quarter\").Add(\"Q2 FY 2003\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                             |
| [excludedRowElement.Hierarchy.LevelElements(\"Fiscal Quarter\").Add(\"Q2 FY 2003\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'\'\'Adding Column Members]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                             |
| [olapReport.CategoricalElements.Add(dimensionElementColumn,excludedColumnElement)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'\'\'Adding Measure Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                             |
| [olapReport.CategoricalElements.Add(measureElementColumn)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                             |
| [\'\'\'Adding Row Members]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                             |
| [olapReport.SeriesElements.Add(dimensionElementRow,excludedRowElement)       ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
