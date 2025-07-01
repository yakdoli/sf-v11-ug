::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b8c3a273-a896-498d-afd0-1651b09d683a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f6471825-74bb-400f-8937-7a79d4b3af1d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET MVC](ms-xhelp:///?Id=32b055b8-3bdf-473c-bb73-f99a534ce79c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How To](ms-xhelp:///?Id=b8c3a273-a896-498d-afd0-1651b09d683a){.d2h_breadcrumbsNormal}
:::

## Sample OlapReport {#sample-olapreport style="tab-stops: 0pt"}

[]{style="COLOR: #c00000"} 

This report uses the "Adventure Works" cube for dimension and measures definition.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                      |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\<summary\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}                                            |
|                                                                                                                                                                                                                      |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Defining OlapReport with Dimensions and Measures]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                          |
|                                                                                                                                                                                                                      |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\</summary\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}                                           |
|                                                                                                                                                                                                                      |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\<returns\>\</returns\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}                                |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [OlapReport]{style="COLOR: #2b91af"} ]{style="FONT-FAMILY: 'Courier New'"}[CreateOlapReport()]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                      |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [        [OlapReport]{style="COLOR: #2b91af"} olapReport = [new]{style="COLOR: blue"} [OlapReport]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                      |
| [        [// Selecting the Cube]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                      |
| [        olapReport.CurrentCubeName = [\"Adventure Works\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [        [DimensionElement]{style="COLOR: #2b91af"} dimensionElementColumn = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                      |
| [        [// Specifying the Name for Column Dimension Element]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                      |
| [        dimensionElementColumn.Name = [\"Customer\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                      |
| [        [// Specifying the Hierarchy and Level Element Name]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                      |
| [        dimensionElementColumn.AddLevel([\"Customer Geography\"]{style="COLOR: #a31515"}, [\"Country\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [        [MeasureElements]{style="COLOR: #2b91af"} measureElementColumn = [new]{style="COLOR: blue"} [MeasureElements]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                                      |
| [        [//Specifying the Measure Elements]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                      |
| [        measureElementColumn.Elements.Add([new]{style="COLOR: blue"} [MeasureElement]{style="COLOR: #2b91af"} { Name = [\"Internet Sales Amount\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [        [DimensionElement]{style="COLOR: #2b91af"} dimensionElementRow = [new]{style="COLOR: blue"} [DimensionElement]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                      |
| [        [//Specifying the Name for Row Dimension Element]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                      |
| [        dimensionElementRow.Name = [\"Date\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                      |
| [        [// Specifying the Hierarchy and Level Element Name]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                      |
| [        dimensionElementRow.AddLevel([\"Fiscal\"]{style="COLOR: #a31515"}, [\"Fiscal Year\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [        [///]{style="COLOR: gray"}[Adding Column Members]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                      |
| [        olapReport.CategoricalElements.Add(dimensionElementColumn);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                      |
| [        [///]{style="COLOR: gray"}[Adding Measure Element]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                      |
| [        olapReport.CategoricalElements.Add(measureElementColumn);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                      |
| [        [///]{style="COLOR: gray"}[Adding Row Members]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                      |
| [        olapReport.SeriesElements.Add(dimensionElementRow);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [        [return]{style="COLOR: blue"} olapReport;    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                      |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

[]{style="COLOR: #c00000"} 

 

 

 

 

 

 

 

 

 

 

 

 

 

**Workflow Information**

Before submitting this content to the Documentation team, make sure Fields 1-4 and Field 7 have been filled out. Do not delete this page.

+-------------------------------------+-----------------------------------------+
|                                                                               |
|                                                                               |
| **Feature Request ID:5373**                                                   |
|                                                                               |
|                                                                               |
+-------------------------------------+-----------------------------------------+
| **1.   Content Contributor:**       | Bharath and Sylvia Praveen              |
+-------------------------------------+-----------------------------------------+
| **2.   Team Lead:**                 | Rajadurai C                             |
+-------------------------------------+-----------------------------------------+
| **3.   Technical Reviewer:**        | Rajadurai C                             |
+-------------------------------------+-----------------------------------------+
| **4.   Date Reviewed:**             | 14^th^ Oct 2011                         |
+-------------------------------------+-----------------------------------------+
| **Comments:**                       | Please accept changes made in document. |
+-------------------------------------+-----------------------------------------+
| **5.   Content Editor:**            | Sylvia Praveen                          |
+-------------------------------------+-----------------------------------------+
| **6.   Date Reviewed:**             | 14^th^ Oct 2011                         |
+-------------------------------------+-----------------------------------------+
| **Comments:**                       |                                         |
+-------------------------------------+-----------------------------------------+
| **Location in the UG**              | New UG                                  |
+-------------------------------------+-----------------------------------------+
| **7.   Status:**                    | **Content Review Completed**            |
+-------------------------------------+-----------------------------------------+

 

 

[]{style="COLOR: #c00000"} 

[]{#related-topics}
::::
