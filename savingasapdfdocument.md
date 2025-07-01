::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=91671838-0aa3-4c06-a73d-29bcfb57a1d3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=62d28f0e-3da1-4c3b-906f-83ee9f93bea9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Saving as a PDF Document {#saving-as-a-pdf-document style="tab-stops: 0pt"}

The RDL report generated using the Report Designer can be exported as a PDF document using the following code.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                             |
|                                                                                                                                                                                              |
| [//Instantiate the report writer with the parameter \"ReportPath\" and ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                   |
|                                                                                                                                                                                              |
| ["ReportDataSource" Collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                              |
| [ReportWriter ]{style="FONT-FAMILY: 'Courier New'; COLOR: #4bacc6"}[reportWriter = new [ReportWriter]{style="COLOR: #4bacc6"}(reportpath, dataSources);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [reportWriter.Save(\"Sample.pdf\", ]{style="FONT-FAMILY: 'Courier New'"}[WriterFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.PDF);]{style="FONT-FAMILY: 'Courier New'"}       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                  |
| [\'Instantiate the report writer with the parameter \"ReportPath\" and ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                  |
| [ReportDataSource Collection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                  |
| [Dim ]{style="FONT-FAMILY: 'Courier New'; COLOR: #0070c0"}[reportWriter [As New ]{style="COLOR: #0070c0"}]{style="FONT-FAMILY: 'Courier New'"}[ReportWriter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ (reportpath, dataSources)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                  |
| [reportWriter.Save(\"Sample.pdf\", ]{style="FONT-FAMILY: 'Courier New'"}[WriterFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.PDF);]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
