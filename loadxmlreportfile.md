::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3b38f110-bcd8-41c0-8fff-03c7b295f6bd){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c8ce1fc6-2845-4b30-9b5c-ee81500f059d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How-To](ms-xhelp:///?Id=f56652ff-a795-456f-ba4a-e1b615c58fdd){.d2h_breadcrumbsNormal}
:::

## Load xml report file {#load-xml-report-file style="tab-stops: 0pt"}

You can load the xml report set by using the LoadReport method.

The following code snippet will illustrate the loading of the report:

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                               |
| [olapDataManager.LoadReport([@\"C:\\SampleReport\\RevenueAnalysis.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                             |
| [       ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                             |
| [olapDataManager.LoadReport([\"C:\\SampleReport\\RevenueAnalysis.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

For Silverlight:

 

The saved report file can be used with OlapDataManager by serializing it to type OlapReport with **XmlSerializer.**

The following code snippet will illustrate the loading of a saved xml report file:

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                       |
| [ [private]{style="COLOR: blue"} [void]{style="COLOR: blue"} LoadReport()\                                                                                                                                                                                            |
|  {\                                                                                                                                                                                                                                                                   |
|     [OpenFileDialog]{style="COLOR: #2b91af"} dlg = [new]{style="COLOR: blue"} [OpenFileDialog]{style="COLOR: #2b91af"}();\                                                                                                                                            |
|     dlg.Filter = [\"XML files (\*.xml)\|\*.xml\"]{style="COLOR: #a31515"};\                                                                                                                                                                                           |
|     [bool]{style="COLOR: blue"}? b = dlg.ShowDialog();\                                                                                                                                                                                                               |
|  \                                                                                                                                                                                                                                                                    |
|     [if]{style="COLOR: blue"} (b.HasValue && b.Value)\                                                                                                                                                                                                                |
|     {\                                                                                                                                                                                                                                                                |
|         [OlapReport]{style="COLOR: #2b91af"} report = [null]{style="COLOR: blue"};\                                                                                                                                                                                   |
|  \                                                                                                                                                                                                                                                                    |
|         [using]{style="COLOR: blue"} ([FileStream]{style="COLOR: #2b91af"} stream = dlg.File.OpenRead())\                                                                                                                                                             |
|         {\                                                                                                                                                                                                                                                            |
|            System.Xml.Serialization.[XmlSerializer]{style="COLOR: #2b91af"} serializer = [new]{style="COLOR: blue"} System.Xml.Serialization.[XmlSerializer]{style="COLOR: #2b91af"}([typeof]{style="COLOR: blue"}([OlapReportCollection]{style="COLOR: #2b91af"}));\ |
|            [OlapReportCollection]{style="COLOR: #2b91af"} olapReportCollection = serializer.Deserialize(stream) [as]{style="COLOR: blue"} [OlapReportCollection]{style="COLOR: #2b91af"};\                                                                            |
|           report = olapReportCollection\[0\];                       \                                                                                                                                                                                                 |
|         }\                                                                                                                                                                                                                                                            |
|         olapDataManager.SetCurrentReport(report);         \                                                                                                                                                                                                           |
|     }            \                                                                                                                                                                                                                                                    |
|  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                       |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} LoadReport()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                                                                       |
| [      [Dim]{style="COLOR: blue"} dlg [As]{style="COLOR: blue"} OpenFileDialog = [New]{style="COLOR: blue"} OpenFileDialog()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                                                                       |
| [      dlg.Filter = \"XML files (\*.xml)\|\*.xml\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                       |
| [      [Dim]{style="COLOR: blue"} b [As]{style="COLOR: blue"} Nullable([Of]{style="COLOR: blue"} [Boolean]{style="COLOR: blue"}) = dlg.ShowDialog()]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                       |
| [      [If]{style="COLOR: blue"} b.HasValue [AndAlso]{style="COLOR: blue"} b.Value [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                                                       |
| [            [Dim]{style="COLOR: blue"} report [As]{style="COLOR: blue"} OlapReport = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                       |
| [            [Using]{style="COLOR: blue"} stream [As]{style="COLOR: blue"} FileStream = dlg.File.OpenRead()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                                                       |
| [               [Dim]{style="COLOR: blue"} serializer [As]{style="COLOR: blue"} System.Xml.Serialization.XmlSerializer = [New]{style="COLOR: blue"} System.Xml.Serialization.XmlSerializer([GetType]{style="COLOR: blue"}(OlapReportCollection))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                       |
| [               [Dim]{style="COLOR: blue"} olapReportCollection [As]{style="COLOR: blue"} OlapReportCollection = TryCast(serializer.Deserialize(stream), OlapReportCollection)]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                                                                                       |
| [              report = olapReportCollection(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                       |
| [            [End]{style="COLOR: blue"} [Using]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                       |
| [            olapDataManager.SetCurrentReport(report)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                       |
| [      [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                       |
| [ [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
