::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3c63f21f-f056-452c-bf22-88ffa057f38c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=998d3e8a-101c-442a-8d90-babfc03ab646){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How-To](ms-xhelp:///?Id=f56652ff-a795-456f-ba4a-e1b615c58fdd){.d2h_breadcrumbsNormal}
:::

## Save the report as xml file {#save-the-report-as-xml-file style="tab-stops: 0pt"}

The user can save the current report set of OlapDataManager as an xml file for the future needsby using the SaveReport method.

The following code snippet will illustrate the saving of the current report set as an xml file:

+-----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                        |
|                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                         |
| [olapDataManager.SaveReport([@\"C:\\SampleReport\\RevenueAnalysis.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                      |
|                                                                                                                                       |
| [       ]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                       |
| [olapDataManager.SaveReport([\"C:\\SampleReport\\RevenueAnalysis.xml\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
+---------------------------------------------------------------------------------------------------------------------------------------+

 

For Silverlight:

 

You can save the current report of OlapDataManger as an xml file for their future use by serializing the report with **XmlSerializer**.

The following code snippet will illustrate the saving of the current report set as an xml file:

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [private]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ [void]{style="COLOR: blue"} SaveReport()\                                                                                                                                                          |
| {\                                                                                                                                                                                                                                                        |
|    [SaveFileDialog]{style="COLOR: #2b91af"} dlg = [new]{style="COLOR: blue"} [SaveFileDialog]{style="COLOR: #2b91af"}();\                                                                                                                                 |
|    dlg.Filter = [\"XML files (\*.xml)\|\*.xml\"]{style="COLOR: #a31515"};\                                                                                                                                                                                |
|  \                                                                                                                                                                                                                                                        |
|    [bool]{style="COLOR: blue"}? b = dlg.ShowDialog();\                                                                                                                                                                                                    |
|  \                                                                                                                                                                                                                                                        |
|    [if]{style="COLOR: blue"} (b.HasValue && b.Value)\                                                                                                                                                                                                     |
|    {\                                                                                                                                                                                                                                                     |
|       [using]{style="COLOR: blue"} ([Stream]{style="COLOR: #2b91af"} stream = dlg.OpenFile())\                                                                                                                                                            |
|       {\                                                                                                                                                                                                                                                  |
|          System.Xml.Serialization.[XmlSerializer]{style="COLOR: #2b91af"} serializer = [new]{style="COLOR: blue"} System.Xml.Serialization.[XmlSerializer]{style="COLOR: #2b91af"}([typeof]{style="COLOR: blue"}([OlapReport]{style="COLOR: #2b91af"}));\ |
|          serializer.Serialize(stream, [this]{style="COLOR: blue"}.olapDataManager.CurrentReport);             \                                                                                                                                           |
|       }\                                                                                                                                                                                                                                                  |
|    }            \                                                                                                                                                                                                                                         |
| }]{style="FONT-FAMILY: Consolas"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} SaveReport()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                                                           |
| [   [Dim]{style="COLOR: blue"} dlg [As]{style="COLOR: blue"} SaveFileDialog = [New]{style="COLOR: blue"} SaveFileDialog()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                                           |
| [   dlg.Filter = \"XML files (\*.xml)\|\*.xml\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                           |
| [   [Dim]{style="COLOR: blue"} b [As]{style="COLOR: blue"} Nullable([Of]{style="COLOR: blue"} [Boolean]{style="COLOR: blue"}) = dlg.ShowDialog()]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                           |
| [   [If]{style="COLOR: blue"} b.HasValue [AndAlso]{style="COLOR: blue"} b.Value [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                                                           |
| [        [Using]{style="COLOR: blue"} stream [As]{style="COLOR: blue"} Stream = dlg.OpenFile()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                                                           |
| [             [Dim]{style="COLOR: blue"} serializer [As]{style="COLOR: blue"} System.Xml.Serialization.XmlSerializer = [New]{style="COLOR: blue"} System.Xml.Serialization.XmlSerializer([GetType]{style="COLOR: blue"}(OlapReport))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                           |
| [             serializer.Serialize(stream, [Me]{style="COLOR: blue"}.olapDataManager.CurrentReport)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                                                           |
| [        [End]{style="COLOR: blue"} [Using]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                           |
| [   [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
