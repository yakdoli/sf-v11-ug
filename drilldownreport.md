::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Drill down report {#drill-down-report style="tab-stops: 0pt"}

 

+------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                     |
|                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                      |
| [OlapReport]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ olapReport = [new]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"}();\   |
| olapReport.Name = [\"Customer Report\"]{style="COLOR: #a31515"};\                                                                                    |
| olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"};\                                                                         |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementColumn = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\        |
| [//Specifying the Name for the Dimension Element]{style="COLOR: green"}\                                                                             |
| dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"};\                                                                               |
| [//Specifying the Hierarchy Name]{style="COLOR: green"}\                                                                                             |
| dimensionElementColumn.HierarchyName = [\"Customer Geography\"]{style="COLOR: #a31515"};\                                                            |
| dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});\                           |
|  \                                                                                                                                                   |
| [MeasureElements]{style="COLOR: #2b91af"} measureElementColumn = [new]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"}();\            |
| measureElementColumn.Elements.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                      |
| [                                 [\"Internet Sales Amount\"]{style="COLOR: #a31515"} });\                                                           |
|  \                                                                                                                                                   |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementRow = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\           |
| [//Specifying the Dimension Name]{style="COLOR: green"}\                                                                                             |
| dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"};\                                                                                      |
| dimensionElementRow.HierarchyName = [\"Fiscal\"]{style="COLOR: #a31515"};\                                                                           |
| dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});\                                      |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].Add([\"FY 2002\"]{style="COLOR: #a31515"});\                |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                      |
| [                             MemberElements\[0\].ShowChildMembers = [true]{style="COLOR: blue"};\                                                   |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                      |
| [                             MemberElements\[0\].Add([\"H1 FY 2002\"]{style="COLOR: #a31515"});\                                                    |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                      |
| [      MemberElements\[0\].ChildMemberElements\[0\].ShowChildMembers = [true]{style="COLOR: blue"};\                                                 |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                      |
| [MemberElements\[0\].ChildMemberElements\[0\].Add([\"Q1 FY 2002\"]{style="COLOR: #a31515"});\                                                        |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                      |
| [MemberElements\[0\].ChildMemberElements\[0\].]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                      |
| [ChildMemberElements\[0\].ShowChildMembers = [true]{style="COLOR: blue"};\                                                                           |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                      |
| [MemberElements\[0\].ChildMemberElements\[0\].]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                      |
| [ChildMemberElements\[0\].Add([\"July 2001\"]{style="COLOR: #a31515"});\                                                                             |
| dimensionElementRow.Hierarchy.LevelElements\[[\"Fiscal Year\"]{style="COLOR: #a31515"}\].]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                      |
| [MemberElements\[0\].ChildMemberElements\[0\].]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                      |
| [ChildMemberElements\[0\].ChildMemberElements\[0\].ShowChildMembers = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                            |
| [\                                                                                                                                                                                                                                         |
| ]{style="FONT-FAMILY: 'Courier New'"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapReport [As]{style="COLOR: blue"} OlapReport = [New]{style="COLOR: blue"} OlapReport()]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                                                            |
| [olapReport.Name = [\"Customer Report\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                            |
| [olapReport.CurrentCubeName = \"Adventure Works\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementColumn [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                            |
| [\'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementColumn.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                            |
| [dimensionElementColumn.AddLevel(\"Customer Geography\", \"Country\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                            |
| [\'Creating Measure Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapReport [As]{style="COLOR: blue"} OlapReport = [New]{style="COLOR: blue"} OlapReport()]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                                            |
| [olapReport.CurrentCubeName = \"Adventure Works\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementColumn [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                            |
| [\'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementColumn.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                            |
| [\'Specifying the Hierarchy Name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementColumn.HierarchyName = \"Customer Geography\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapReport [As]{style="COLOR: blue"} OlapReport = [New]{style="COLOR: blue"} OlapReport()]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                                            |
| [olapReport.CurrentCubeName = \"Adventure Works\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementColumn [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                            |
| [\'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementColumn.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                            |
| [\'Specifying the Hierarchy Name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementColumn.HierarchyName = \"Customer Geography\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                            |
| [dimensionElementColumn.AddLevel(\"Customer Geography\", \"Country\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ measureElementColumn [As]{style="COLOR: blue"} MeasureElements = [New]{style="COLOR: blue"} MeasureElements()]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                                            |
| [measureElementColumn.Elements.Add([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = \"Internet Sales Amount\"})]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementRow [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                                                            |
| [\'Specifying the Dimension Name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Name = \"Date\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.HierarchyName = \"Fiscal\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.AddLevel(\"Fiscal\", \"Fiscal Year\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\").Add(\"FY 2002\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\"). MemberElements(0).ShowChildMembers = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\"). MemberElements(0).Add(\"H1 FY 2002\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\"). MemberElements(0).ChildMemberElements(0).ShowChildMembers = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\"). MemberElements(0).ChildMemberElements(0).Add(\"Q1 FY 2002\")]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\"). MemberElements(0).ChildMemberElements(0). ChildMemberElements(0).ShowChildMembers = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\"). MemberElements(0).ChildMemberElements(0). ChildMemberElements(0).Add(\"July 2001\")]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                            |
| [dimensionElementRow.Hierarchy.LevelElements(\"Fiscal Year\"). MemberElements(0).ChildMemberElements(0). ChildMemberElements(0).ChildMemberElements(0).ShowChildMembers = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
