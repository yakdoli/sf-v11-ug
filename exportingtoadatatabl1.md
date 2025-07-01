::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Exporting to a Data Table {#exporting-to-a-data-table style="tab-stops: 0pt"}

Similarly, you can to export the Spreadsheet data to a data table by using the ExportDataTable method of Worksheet. The following code demonstrates this:

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                           |
| [IWorksheet]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ sheet  = [this]{style="COLOR: blue"}.spreadsheetControl.ExcelProperties.WorkBook.Worksheets\[0\];]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                        |
|                                                                                                                                                                                                                                                                                           |
| [IRange]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ range = sheet.Range\[[\"A1:K50\"]{style="COLOR: #a31515"}\];]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                 |
|                                                                                                                                                                                                                                                                                           |
| [DataTable]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[ Dt = sheet.ExportDataTable(range, [ExcelExportDataTableOptions]{style="COLOR: #2b91af"}.ColumnNames);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                     |
|                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ sheet [As]{style="COLOR: blue"} [IWorksheet]{style="COLOR: #2b91af"} = [Me]{style="COLOR: blue"}.spreadsheetControl.ExcelProperties.WorkBook.Worksheets(0)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}         |
|                                                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ range [As]{style="COLOR: blue"} [IRange]{style="COLOR: #2b91af"} = sheet.Range([\"A1:K50\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                               |
|                                                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ Dt [As]{style="COLOR: blue"} [DataTable]{style="COLOR: #2b91af"} = sheet.ExportDataTable(range, [ExcelExportDataTableOptions]{style="COLOR: #2b91af"}.ColumnNames)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
