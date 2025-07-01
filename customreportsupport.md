::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3c895781-b1ed-4987-888d-aa929836a96d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8747ebe5-ae8a-4ba9-8941-3249721faa65){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Silverlight](ms-xhelp:///?Id=c006b39c-6aa2-4637-b7de-3e7b6cb3f9f9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Features](ms-xhelp:///?Id=4ae10797-e3a8-4270-b8ba-34441d2e1a3d){.d2h_breadcrumbsNormal}
:::

## Custom Report Support {#custom-report-support style="tab-stops: 0pt"}

OLAP Client allows you to view your own report created using the report creation Application Programming Interfaces (APIs). There are two ways to view custom report in OLAP client:

 

You can view the custom report by binding it to the OlapDataManager before assigning the OlapDataManager to the OlapClient's OlapDataManager property.

You can also use AddCustomReport method of OlapClient to view the custom report. This method will get the report and add it to the current session's report list and set the newly added report as the current report.

Code snippet

Binding Custom Report

 

+------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                         |
|                                                                                          |
| [//// Initializing OlapDataManager]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                          |
| [OlapDataManager OlapDataManager = new OlapDataManager();\                               |
| OlapDataManager.DataProvider = this.DataProvider;\                                       |
|  \                                                                                       |
|  //// Binding Custom Report with OlapDataManager\                                        |
|  OlapDataManager.SetCurrentReport(CreateOlapReport());\                                  |
|  this.OlapClient.OlapDataManager = OlapDataManager;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                   |
+------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                     |
|                                                                                                      |
| [\'Initializing OlapDataManager]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                      |
| [Dim OlapDataManager As OlapDataManager = New OlapDataManager()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                      |
| [OlapDataManager.DataProvider = Me.DataProvider]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                      |
| [ \'Binding Custom Report with OlapDataManager]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                      |
| [ OlapDataManager.SetCurrentReport(CreateOlapReport())]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                      |
| [ Me.OlapClient.OlapDataManager = OlapDataManager]{style="FONT-FAMILY: 'Courier New'"}               |
+------------------------------------------------------------------------------------------------------+

 

Adding Custom Report

 

+------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                            |
| [//// To add custom report\                                                                                |
| this.OlapClient.AddCustomReport(\"SalesReport\", CreateOlapReport());]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                     |
+------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                         |
|                                                                                                          |
| [\'To add custom report]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                          |
| [Me.OlapClient.AddCustomReport(\"SalesReport\", CreateOlapReport())]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------+

 

Custom Report

 

+------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                     |
|                                                                                                      |
| [        /// \<summary\>\                                                                            |
|         /// Creates an olap report.\                                                                 |
|         /// \</summary\>\                                                                            |
|         /// \<returns\>\</returns\>\                                                                 |
|         private Syncfusion.OlapSilverlight.Reports.OlapReport CreateOlapReport()\                    |
|         {\                                                                                           |
|             OlapReport olapReport = new OlapReport();\                                               |
|             olapReport.Name = \"Sales Report\";\                                                     |
|             olapReport.CurrentCubeName = \"Adventure Works\";\                                       |
|  \                                                                                                   |
|             DimensionElement dimensionElementColumn = new DimensionElement();\                       |
|             //Specifying the Name for the Dimension Element\                                         |
|             dimensionElementColumn.Name = \"Date\";\                                                 |
|             //Adding the level elemnet along with the Hierarchy Name\                                |
|             dimensionElementColumn.AddLevel(\"Fiscal\", \"Fiscal Year\");\                           |
|  \                                                                                                   |
|             DimensionElement dimensionElementRow = new DimensionElement();\                          |
|             //Specifying the Name for the Dimension Element\                                         |
|             dimensionElementRow.Name = \"Customer\";\                                                |
|             //Adding the level elemnet along with the Hierarchy Name\                                |
|             dimensionElementRow.AddLevel(\"Customer Geography\", \"Country\");\                      |
|  \                                                                                                   |
|             //// Creating a Measure element\                                                         |
|             MeasureElements measureElement = new MeasureElements();\                                 |
|             measureElement.Elements.Add(new MeasureElement { Name = \"Internet Sales Amount\" });\   |
|  \                                                                                                   |
|             ////Adding Diemnsion element to categorical axis\                                        |
|             olapReport.CategoricalElements.Add(new Item { ElementValue = dimensionElementColumn });\ |
|  \                                                                                                   |
|             ////Adding Measure element to categorical axis\                                          |
|             olapReport.CategoricalElements.Add(new Item { ElementValue = measureElement });\         |
|  \                                                                                                   |
|             ///Adding Dimenions element to series axis\                                              |
|             olapReport.SeriesElements.Add(new Item { ElementValue = dimensionElementRow });\         |
|  \                                                                                                   |
|             return olapReport;\                                                                      |
|         }]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                               |
+------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                   |
|                                                                                                                                                    |
| [            \'\'\' \<summary\>]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                    |
| [            \'\'\' Creates an olap report.]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                    |
| [            \'\'\' \</summary\>]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                    |
| [            \'\'\' \<returns\>\</returns\>]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                    |
| [            Private Function CreateOlapReport() As Syncfusion.OlapSilverlight.Reports.OlapReport]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                    |
| [                  Dim olapReport As OlapReport = New OlapReport()]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                    |
| [                  olapReport.Name = \"Sales Report\"]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                    |
| [                  olapReport.CurrentCubeName = \"Adventure Works\"]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [                  Dim dimensionElementColumn As DimensionElement = New DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                    |
| [                  \'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                    |
| [                  dimensionElementColumn.Name = \"Date\"]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                    |
| [                  \'Adding the level elemnet along with the Hierarchy Name]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                    |
| [                  dimensionElementColumn.AddLevel(\"Fiscal\", \"Fiscal Year\")]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [                  Dim dimensionElementRow As DimensionElement = New DimensionElement()]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                    |
| [                  \'Specifying the Name for the Dimension Element]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                    |
| [                  dimensionElementRow.Name = \"Customer\"]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                    |
| [                  \'Adding the level elemnet along with the Hierarchy Name]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                    |
| [                  dimensionElementRow.AddLevel(\"Customer Geography\", \"Country\")]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [                  \'// Creating a Measure element]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                    |
| [                  Dim measureElement As MeasureElements = New MeasureElements()]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                    |
| [.Elements.Add(New MeasureElement With {.Name = \"Internet Sales Amount\"})]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [                  \'//Adding Diemnsion element to categorical axis]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                    |
| [                  olapReport.CategoricalElements.Add(New Item With {.ElementValue = dimensionElementColumn})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [                  \'//Adding Measure element to categorical axis]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                    |
| [                  olapReport.CategoricalElements.Add(New Item With {.ElementValue = measureElement})]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [                  \'\'\'Adding Dimenions element to series axis]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                    |
| [\'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                    |
| [\'ORIGINAL LINE: olapReport.SeriesElements.Add(New Item { ElementValue = dimensionElementRow });]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                    |
| [                  olapReport.SeriesElements.Add(New Item With {.ElementValue = dimensionElementRow})]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                    |
| [                  Return olapReport]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                    |
| [            End Function]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
+----------------------------------------------------------------------------------------------------------------------------------------------------+

 

Use Case Scenarios

Custom Report Support will be useful when users want to view reports that were created for an OLAP control using Report Creation API, in OLAP Client.

[]{#related-topics}
::::
