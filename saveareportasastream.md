::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=03032598-4bba-47b1-89d2-34d32f8963fb){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bf585262-493a-41b9-a346-f63b5e75614f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
## Save a Report as a Stream? {#save-a-report-as-a-stream style="tab-stops: 0pt"}

You can save a report as a stream using **Save(Stream,WriterFormat)** (overloaded method). This method is useful when generating the report on the server side and sending it to a client-side application. The following code explains how to save a report as a stream.

[]{style="COLOR: #c00000"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                    |
|                                                                                                                                                                                                                         |
| [//Step 1: create the report data source]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                         |
| [ReportDataSourceCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dataSources = [new]{style="COLOR: blue"} [ReportDataSourceCollection]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                         |
| [dataSources.Add([new]{style="COLOR: blue"} [ReportDataSource]{style="COLOR: #2b91af"}() { Name = [\"Sales\"]{style="COLOR: #a31515"}, Value = GetDataSource() });]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                         |
| [//Step 2: Instantiate the report writer with the parameter \"ReportPath\" and ReportDataSource Collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                         |
| [ReportWriter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ reportWriter = [new]{style="COLOR: blue"} [ReportWriter]{style="COLOR: #2b91af"}(reportPath, dataSources);]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                         |
| [MemoryStream]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ stream = [new]{style="COLOR: blue"} [MemoryStream]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                                         |
| [//Step 3: Save the report as PDF, Word or Excel document in the form of stream contents]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                         |
| [reportWriter.Save(stream,]{style="FONT-FAMILY: 'Courier New'"}[ WriterFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.PDF);]{style="FONT-FAMILY: 'Courier New'"}                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                   |
|                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                    |
| [\'Step 1: Create the report data source]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dataSources [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [ReportDataSourceCollection]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                                                                    |
| [dataSources.Add([New]{style="COLOR: blue"} [ReportDataSource]{style="COLOR: #2b91af"}() [With]{style="COLOR: blue"} {.Name = [\"Sales\"]{style="COLOR: #a31515"}, .Value = GetDataSource()})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [\'Step 2: Instantiate the report writer with the parameter \"ReportPath\" and ReportDataSource Collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ reportWriter [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [ReportWriter]{style="COLOR: #2b91af"}(reportPath, dataSources)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ stream [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [MemoryStream]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                                                    |
| [\'Step 3: Save the report as PDF, Word or Excel document in the form of stream contents]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                                                    |
| [reportWriter.Save(stream]{style="FONT-FAMILY: 'Courier New'"}[ WriterFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.PDF)]{style="FONT-FAMILY: 'Courier New'"}                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
