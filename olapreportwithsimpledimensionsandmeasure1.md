::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=28ef6568-a490-4eb9-8e87-fc1a961b29f3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e991c962-4733-4932-ad5c-3e27db8c5be1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Grid]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Frequently asked questions](ms-xhelp:///?Id=345d79d3-3141-4925-a4ce-32673da65509){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Sample Reports](ms-xhelp:///?Id=28ef6568-a490-4eb9-8e87-fc1a961b29f3){.d2h_breadcrumbsNormal}
:::

### OlapReport with Simple Dimensions and Measure {#olapreport-with-simple-dimensions-and-measure style="tab-stops: 0pt"}

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                                                                                        |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [///]{style="COLOR: gray"} []{style="COLOR: green"} [\<summary\>]{style="COLOR: gray"}                                                                                        |
|                                                                                                                                                                               |
| [///]{style="COLOR: gray"} [ Defining OlapReport with Dimensions and Measures]{style="COLOR: green"}                                                                          |
|                                                                                                                                                                               |
| [///]{style="COLOR: gray"} []{style="COLOR: green"} [\</summary\>]{style="COLOR: gray"}                                                                                       |
|                                                                                                                                                                               |
| [///]{style="COLOR: gray"} []{style="COLOR: green"} [\<returns\>\</returns\>]{style="COLOR: gray"}                                                                            |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
| [private]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"} CreateOlapReport()                                                                                        |
|                                                                                                                                                                               |
| {                                                                                                                                                                             |
|                                                                                                                                                                               |
|         [OlapReport]{style="COLOR: #2b91af"} olapReport = [new]{style="COLOR: blue"}[OlapReport]{style="COLOR: #2b91af"}();                                                   |
|                                                                                                                                                                               |
|         [// Selecting the Cube]{style="COLOR: green"}                                                                                                                         |
|                                                                                                                                                                               |
|         olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"};                                                                                           |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|         [DimensionElement]{style="COLOR: #2b91af"} dimensionElementColumn = [new]{style="COLOR: blue"}[DimensionElement]{style="COLOR: #2b91af"}();                           |
|                                                                                                                                                                               |
|         [// Specifying the Name for Column Dimension Element]{style="COLOR: green"}                                                                                           |
|                                                                                                                                                                               |
|         dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"};                                                                                                 |
|                                                                                                                                                                               |
|         [// Specifying the Hierarchy and Level Element Name]{style="COLOR: green"}                                                                                            |
|                                                                                                                                                                               |
|         dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});                                             |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|         [MeasureElements]{style="COLOR: #2b91af"} measureElementColumn = [new]{style="COLOR: blue"}[MeasureElements]{style="COLOR: #2b91af"}();                               |
|                                                                                                                                                                               |
|         [//Specifying the Measure Elements]{style="COLOR: green"}                                                                                                             |
|                                                                                                                                                                               |
|         measureElementColumn.Elements.Add([new]{style="COLOR: blue"}[MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Internet Sales Amount\"]{style="COLOR: #a31515"} }); |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|         [DimensionElement]{style="COLOR: #2b91af"} dimensionElementRow = [new]{style="COLOR: blue"}[DimensionElement]{style="COLOR: #2b91af"}();                              |
|                                                                                                                                                                               |
|         [//Specifying the Name for Row Dimension Element]{style="COLOR: green"}                                                                                               |
|                                                                                                                                                                               |
|         dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"};                                                                                                        |
|                                                                                                                                                                               |
|         [// Specifying the Hierarchy and Level Element Name]{style="COLOR: green"}                                                                                            |
|                                                                                                                                                                               |
|         dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});                                                        |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|         [///]{style="COLOR: gray"}[Adding Column Members]{style="COLOR: green"}                                                                                               |
|                                                                                                                                                                               |
|         olapReport.CategoricalElements.Add(dimensionElementColumn);                                                                                                           |
|                                                                                                                                                                               |
|         [///]{style="COLOR: gray"}[Adding Measure Element]{style="COLOR: green"}                                                                                              |
|                                                                                                                                                                               |
|         olapReport.CategoricalElements.Add(measureElementColumn);                                                                                                             |
|                                                                                                                                                                               |
|         [///]{style="COLOR: gray"}[Adding Row Members]{style="COLOR: green"}                                                                                                  |
|                                                                                                                                                                               |
|         olapReport.SeriesElements.Add(dimensionElementRow);                                                                                                                   |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
|         [return]{style="COLOR: blue"} olapReport;                                                                                                                             |
|                                                                                                                                                                               |
|  }                                                                                                                                                                            |
|                                                                                                                                                                               |
|                                                                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[VB\]                                                                                                                                                                                    |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [\'\'\' \<summary\>]{style="COLOR: green"}                                                                                                                                                |
|                                                                                                                                                                                           |
| [\'\'\' Defining OlapReport with Dimensions and Measures]{style="COLOR: green"}                                                                                                           |
|                                                                                                                                                                                           |
| [\'\'\' \</summary\>]{style="COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                           |
| [\'\'\' \<returns\>\</returns\>]{style="COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                           |
| [Private]{style="COLOR: blue"} [Function]{style="COLOR: blue"} CreateOlapReport() [As]{style="COLOR: blue"} OlapReport                                                                    |
|                                                                                                                                                                                           |
|                    [Dim]{style="COLOR: blue"} olapReport [As]{style="COLOR: blue"} OlapReport = [New]{style="COLOR: blue"} OlapReport()                                                   |
|                                                                                                                                                                                           |
|                    [\' Selecting the Cube]{style="COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                           |
|                    olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #c00000"}                                                                                             |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                    [Dim]{style="COLOR: blue"} dimensionElementColumn [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()                           |
|                                                                                                                                                                                           |
|                    [\' Specifying the Name for Column Dimension Element]{style="COLOR: green"}                                                                                            |
|                                                                                                                                                                                           |
|                    dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #c00000"}                                                                                                   |
|                                                                                                                                                                                           |
|                    [\' Specifying the Hierarchy and Level Element Name]{style="COLOR: green"}                                                                                             |
|                                                                                                                                                                                           |
|                    dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #c00000"}, [\"Country\"]{style="COLOR: #c00000"})                                               |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                    [Dim]{style="COLOR: blue"} measureElementColumn [As]{style="COLOR: blue"} MeasureElements = [New]{style="COLOR: blue"} MeasureElements()                               |
|                                                                                                                                                                                           |
|                    [\'Specifying the Measure Elements]{style="COLOR: green"}                                                                                                              |
|                                                                                                                                                                                           |
|                    measureElementColumn.Elements.Add([New]{style="COLOR: blue"} MeasureElement [With]{style="COLOR: blue"} {.Name = [\"Internet Sales Amount\"]{style="COLOR: #c00000"}}) |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                    [Dim]{style="COLOR: blue"} dimensionElementRow [As]{style="COLOR: blue"} DimensionElement = [New]{style="COLOR: blue"} DimensionElement()                              |
|                                                                                                                                                                                           |
|                    [\'Specifying the Name for Row Dimension Element]{style="COLOR: green"}                                                                                                |
|                                                                                                                                                                                           |
|                    dimensionElementRow.Name = [\"Date\"]{style="COLOR: #c00000"}                                                                                                          |
|                                                                                                                                                                                           |
|                    [\' Specifying the Hierarchy and Level Element Name]{style="COLOR: green"}                                                                                             |
|                                                                                                                                                                                           |
|                    dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #c00000"}, [\"Fiscal Year\")]{style="COLOR: #c00000"}                                                          |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                    [\'\'\'Adding Column Members]{style="COLOR: green"}                                                                                                                    |
|                                                                                                                                                                                           |
|                    olapReport.CategoricalElements.Add(dimensionElementColumn)                                                                                                             |
|                                                                                                                                                                                           |
|                    [\'\'\'Adding Measure Element]{style="COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                           |
|                    olapReport.CategoricalElements.Add(measureElementColumn)                                                                                                               |
|                                                                                                                                                                                           |
|                    [\'\'\'Adding Row Members]{style="COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                           |
|                    olapReport.SeriesElements.Add(dimensionElementRow)                                                                                                                     |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                    [Return]{style="COLOR: blue"} olapReport                                                                                                                               |
|                                                                                                                                                                                           |
| [End]{style="COLOR: blue"} [Function]{style="COLOR: blue"}                                                                                                                                |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

[]{#related-topics}
::::
