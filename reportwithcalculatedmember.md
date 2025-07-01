::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Report with calculated member {#report-with-calculated-member style="tab-stops: 0pt"}

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                              |
|                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                               |
| [olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"};\                                                                                                                 |
|  \                                                                                                                                                                                            |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementColumn = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                                                 |
| [//Specifying the Name for the Dimension Element]{style="COLOR: green"}\                                                                                                                      |
| dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"};\                                                                                                                        |
| dimensionElementColumn.HierarchyName = [\"Customer Geography\"]{style="COLOR: #a31515"};\                                                                                                     |
| dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});\                                                                    |
|  \                                                                                                                                                                                            |
| [DimensionElement]{style="COLOR: #2b91af"} internalDimension = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                                                      |
| internalDimension.Name = [\"Product\"]{style="COLOR: #a31515"};\                                                                                                                              |
| internalDimension.AddLevel([\"Product Categories\"]{style="COLOR: #a31515"}, [\"Category\"]{style="COLOR: #a31515"});\                                                                        |
|  \                                                                                                                                                                                            |
| [//// Calculated Measure]{style="COLOR: green"}\                                                                                                                                              |
| [CalculatedMember]{style="COLOR: #2b91af"} calculatedMeasure1 = [new]{style="COLOR: blue"} [CalculatedMember]{style="COLOR: #2b91af"}();\                                                     |
| calculatedMeasure1.Name = [\"Oder on Discount\"]{style="COLOR: #a31515"};\                                                                                                                    |
| calculatedMeasure1.Expression = [\"\[Measures\].\[Order Quantity\] + (\[Measures\].\[Order Quantity\] \* 0.10)\"]{style="COLOR: #a31515"};\                                                   |
| calculatedMeasure1.AddElement([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Order Quantity\"]{style="COLOR: #a31515"} }); \                                 |
|  \                                                                                                                                                                                            |
| [//// Calculated Measure]{style="COLOR: green"}\                                                                                                                                              |
| [CalculatedMember]{style="COLOR: #2b91af"} calculatedMeasure2 = [new]{style="COLOR: blue"} [CalculatedMember]{style="COLOR: #2b91af"}();\                                                     |
| calculatedMeasure2.Name = [\"Sales Range\"]{style="COLOR: #a31515"};\                                                                                                                         |
| calculatedMeasure2.AddElement([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Sales Amount\"]{style="COLOR: #a31515"} });\                                    |
| calculatedMeasure2.Expression = [\"IIF(\[Measures\].\[Sales Amount\]\>200000,\\\"High\\\",\\\"Low\\\")\"]{style="COLOR: #a31515"};\                                                           |
|  \                                                                                                                                                                                            |
| [// Calculated Dimension]{style="COLOR: green"}\                                                                                                                                              |
| [CalculatedMember]{style="COLOR: #2b91af"} calculateDimension = [new]{style="COLOR: blue"} [CalculatedMember]{style="COLOR: #2b91af"}();\                                                     |
| calculateDimension.Name = [\"Bikes & Components\"]{style="COLOR: #a31515"};\                                                                                                                  |
| calculateDimension.Expression = [\"(\[Product\].\[Product Categories\].\[Category\].\[Bikes\] + \[Product\].\[Product Categories\].\[Category\].\[Components\] )\"]{style="COLOR: #a31515"};\ |
| calculateDimension.AddElement(internalDimension);\                                                                                                                                            |
|  \                                                                                                                                                                                            |
| [MeasureElements]{style="COLOR: #2b91af"} measureElementColumn = [new]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"}();\                                                     |
| measureElementColumn.Elements.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Sales Amount\"]{style="COLOR: #a31515"} });\                                |
| measureElementColumn.Elements.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Order Quantity\"]{style="COLOR: #a31515"} });\                              |
|  \                                                                                                                                                                                            |
| [DimensionElement]{style="COLOR: #2b91af"} dimensionElementRow = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();\                                                    |
| [//Specifying the Dimension Name]{style="COLOR: green"}\                                                                                                                                      |
| dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"};\                                                                                                                               |
| dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});\                                                                               |
|  \                                                                                                                                                                                            |
|  \                                                                                                                                                                                            |
| [//// Adding Calculated members in calculated member collection]{style="COLOR: green"}\                                                                                                       |
| olapReport.CalculatedMembers.Add(calculatedMeasure1);\                                                                                                                                        |
| olapReport.CalculatedMembers.Add(calculateDimension);\                                                                                                                                        |
| olapReport.CalculatedMembers.Add(calculatedMeasure2);\                                                                                                                                        |
|  \                                                                                                                                                                                            |
| [///]{style="COLOR: gray"}[ Adding Column Members]{style="COLOR: green"}\                                                                                                                     |
| olapReport.CategoricalElements.Add(dimensionElementColumn);\                                                                                                                                  |
| olapReport.CategoricalElements.Add(calculateDimension);\                                                                                                                                      |
| [///]{style="COLOR: gray"}[Adding Measure Element]{style="COLOR: green"}\                                                                                                                     |
| olapReport.CategoricalElements.Add(measureElementColumn);\                                                                                                                                    |
| olapReport.CategoricalElements.Add(calculatedMeasure1);\                                                                                                                                      |
| olapReport.CategoricalElements.Add(calculatedMeasure2);\                                                                                                                                      |
|  \                                                                                                                                                                                            |
| [///]{style="COLOR: gray"}[Adding Row Members]{style="COLOR: green"}\                                                                                                                         |
| olapReport.SeriesElements.Add(dimensionElementRow);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                               |
| [                               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                               |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementColumn [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                |
| [\'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                |
| [dimensionElementColumn.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                |
| [dimensionElementColumn.HierarchyName = \"Customer Geography\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                |
| [dimensionElementColumn.AddLevel(\"Customer Geography\", \"Country\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ internalDimension [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                |
| [internalDimension.Name = \"Product\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                |
| [internalDimension.AddLevel(\"Product Categories\", \"Category\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [\'// Calculated Measure]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ calculatedMeasure1 [As]{style="COLOR: blue"} CalculatedMember = [New]{style="COLOR: blue"} CalculatedMember()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                |
| [calculatedMeasure1.Name = \"Oder on Discount\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                |
| [calculatedMeasure1.Expression = \"\[Measures\].\[Order Quantity\] + (\[Measures\].\[Order Quantity\] \* 0.10)\"]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                |
| [calculatedMeasure1.AddElement([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = \"Order Quantity\"})]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [\'// Calculated Measure]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ calculatedMeasure2 [As]{style="COLOR: blue"} CalculatedMember = [New]{style="COLOR: blue"} CalculatedMember()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                |
| [calculatedMeasure2.Name = \"Sales Range\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                |
| [calculatedMeasure2.AddElement([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = \"Sales Amount\"})]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                |
| [calculatedMeasure2.Expression = \"IIF(\[Measures\].\[Sales Amount\]\>200000,\"\"High\"\",\"\"Low\"\")\"]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [\' Calculated Dimension]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ calculateDimension [As]{style="COLOR: blue"} CalculatedMember = [New]{style="COLOR: blue"} CalculatedMember()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                |
| [calculateDimension.Name = \"Bikes & Components\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                |
| [calculateDimension.Expression = \"(\[Product\].\[Product Categories\].\[Category\].\[Bikes\] + \[Product\].\[Product Categories\].\[Category\].\[Components\] )\"]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                                |
| [calculateDimension.AddElement(internalDimension)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ measureElementColumn [As]{style="COLOR: blue"} MeasureElements = [New]{style="COLOR: blue"} MeasureElements()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                |
| [measureElementColumn.Elements.Add([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = \"Sales Amount\"})]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                |
| [measureElementColumn.Elements.Add([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = \"Order Quantity\"})]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dimensionElementRow [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                |
| [\'Specifying the Dimension Name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                |
| [dimensionElementRow.Name = \"Date\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                |
| [dimensionElementRow.AddLevel(\"Fiscal\", \"Fiscal Year\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [\'// Adding Calculated members in calculated member collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                |
| [olapReport.CalculatedMembers.Add(calculatedMeasure1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                |
| [olapReport.CalculatedMembers.Add(calculateDimension)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                |
| [olapReport.CalculatedMembers.Add(calculatedMeasure2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [\'\'\' Adding Column Members]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                |
| [olapReport.CategoricalElements.Add(dimensionElementColumn)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                |
| [olapReport.CategoricalElements.Add(calculateDimension)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                |
| [\'\'\'Adding Measure Element]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                |
| [olapReport.CategoricalElements.Add(measureElementColumn)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                |
| [olapReport.CategoricalElements.Add(calculatedMeasure1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                |
| [olapReport.CategoricalElements.Add(calculatedMeasure2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [\'\'\'Adding Row Members]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                |
| [olapReport.SeriesElements.Add(dimensionElementRow)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                |
| [                                              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
