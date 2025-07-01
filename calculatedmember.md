::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7d45808e-ab80-494b-a440-e3cafdd5d9c2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=80188f84-ce64-423e-8eb7-e5e64bf8a505){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OlapReport](ms-xhelp:///?Id=5df0d4a2-dd21-4743-9142-c97b5f6c86e0){.d2h_breadcrumbsNormal}
:::

### Calculated Member {#calculated-member style="tab-stops: 0pt"}

Calculated Members are the customized measures or dimension members created with the cube. The values are calculated at run-time. It is a user defined Element. The two types of calculated members are as follows:

1.   **Calculated Measure** -- Calculated member created from a measure element

2.   **Calculated Dimension** -- Calculated member created from a dimension

 

Calculated Member to be defined in **OlapReport** requires the following definitions:

[·      ]{style="FONT-FAMILY: Symbol"}Name -- Name of the calculated member

[·      ]{style="FONT-FAMILY: Symbol"}Expression -- Expression to form the calculated member

[·      ]{style="FONT-FAMILY: Symbol"}Measure/Dimension Element -- You should add a measure or dimension element from which the calculated member should be created.

The following steps will explain how to create and add a calculated member in an OlapReport

1.   Create the dimension measure or dimension element from which the calculated member has to be created.

2.   Create the calculated member by giving the name and expression.

3.   Add the element created in Step 1 to the calculated member.

4.   Once the calculated member is defined, add that member to the calculated member collection in an OlapReport.

5.   Add the newly created calculated members in the categorical or series axis of an OlapReport.

 

The following code snippet will describe the creation and addition of a calculated member in OlapReport:

Calculated Measure

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [MeasureElement]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ measureElement = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[MeasureElement]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [measureElement.Name = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Order Quantity\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CalculatedMember]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ calculatedMeasure = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[CalculatedMember]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [calculatedMeasure.Name = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Oder on Discount\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[; ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [calculatedMeasure1.Expression = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"\[Measures\].\[Order Quantity\] + (\[Measures\].\[Order Quantity\] \* 0.10)\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [calculatedMeasure1.AddElement(measureElement);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [olapReport.CalculatedMembers.Add(calculatedMeasure);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                          |
|                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ measureElement [As]{style="COLOR: blue"} MeasureElement = [New]{style="COLOR: blue"} MeasureElement()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                           |
| [measureElement.Name = \"[ Order Quantity]{style="COLOR: #c00000"} \"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ calculatedMeasure [As]{style="COLOR: blue"} CalculatedMember = [New]{style="COLOR: blue"} CalculatedMember()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| [calculatedMeasure.Name = \"[ Order on Discount]{style="COLOR: #c00000"} \"]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                           |
| [calculatedMeasure1.Expression = [\"\[Measures\].\[Order Quantity\] + (\[Measures\].\[Order Quantity\] \*0.10)\"]{style="COLOR: #c00000"}]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                           |
| [calculatedMeasure1.AddElement(measureElement)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                           |
| [olapReport.CalculatedMembers.Add(calculatedMeasure)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[Calculated Dimension]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [DimensionElement]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ internalDimension = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[DimensionElement]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}  |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [internalDimension.Name = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Product\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [internalDimension.AddLevel(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Product Categories\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[, ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Category\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [// Calculated Dimension]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [CalculatedMember]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ calculateDimension = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[CalculatedMember]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [calculateDimension.Name = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"Bikes & Components\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [calculateDimension.Expression = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"(\[Product\].\[Product Categories\].]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [\[Category\].\[Bikes\] + \[Product\].\[Product Categories\].\[Category\].]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [\[Components\] )\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [calculateDimension.AddElement(internalDimension);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [olapReport.CalculatedMembers.Add(]{style="FONT-FAMILY: 'Courier New'"}[calculateDimension]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                           |
|                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ internalDimension [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                            |
| [internalDimension.Name = ]{style="FONT-FAMILY: 'Courier New'"}[\"Product\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                            |
| [internalDimension.AddLevel(\"Product Categories\", \"Category\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                            |
| [\' Calculated Dimension]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ calculateDimension [As]{style="COLOR: blue"} CalculatedMember = [New]{style="COLOR: blue"} CalculatedMember()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                            |
| [calculateDimension.Expression = ]{style="FONT-FAMILY: 'Courier New'"}[\"Bikes & Components\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}     |
|                                                                                                                                                                                                            |
| [calculateDimension.Expression = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\"(\[Product\].\[Product Categories\].]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                           |
|                                                                                                                                                                                                            |
| [\[Category\].\[Bikes\] + \[Product\].\[Product Categories\].\[Category\].]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                            |
|                                                                                                                                                                                                            |
| [\[Components\] )\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                            |
| [calculateDimension.AddElement(internalDimension)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                            |
| [olapReport.CalculatedMembers.Add(]{style="FONT-FAMILY: 'Courier New'"}[calculateDimension]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[)]{style="FONT-FAMILY: 'Courier New'"}                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
