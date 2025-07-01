::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4186fa23-4c0f-479b-951f-322305db255d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c987ccb0-3e30-4c83-97d7-cc8c66c07ec4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=ad99231a-9920-49c5-b9a3-8c0224163396){.d2h_breadcrumbsNormal}
:::

## []{style="FONT-SIZE: 10pt"}[]{#p25}[]{#_Saving_a_Workbook}Saving a Workbook {#saving-a-workbook style="tab-stops: 0pt"}

Essential XlsIO is a Non-UI component that can be used on Windows Forms, Web Forms and WPF applications.

Any changes made in a new or existing worksheet will be affected, only if it is saved to a disk or a stream. XlsIO supports saving files to different formats in stream and disk by using the SaveAs method of IWorkbook. The workbook can be saved to stream/disk/response. The only code that is specific for the usage of XlsIO in a Windows Forms application and WPF application, is the saving of the spreadsheet to disk, and for Web Forms applications, it is the streaming of the spreadsheet to the client browser.

The following is the code snippet to save the document to disk.

 

**Saving Worksheet in Windows and WPF Applications**

 

+--------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                                                              |
| [// ]{style="FONT-FAMILY: 'Courier New'"}[Saving the workbook to disk.]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                              |
| [workbook.SaveAs(\"Sample.xls\");]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                   |
|                                                                                                              |
| [\'Saving the workbook to disk.]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                              |
| [workbook.SaveAs(\"Sample.xls\");]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Saving Worksheet in Web Applications

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                 |
|                                                                                                                                                                         |
| [// Stream the workbook to the client browser.]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                         |
| [workbook.SaveAs(\"Sample.xls\", ExcelSaveType.SaveAsXLS, Response, ExcelDownloadType.Open);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                             |
|                                                                                                                                                                        |
| [\'Stream the workbook to the client browser.]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                        |
| [workbook.SaveAs(\"Sample.xls\", ExcelSaveType.SaveAsXLS, Response, ExcelDownloadType.Open)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Similarly, you can open an xlsx file inside the browser by using the following code snippet.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                         |
|                                                                                                                                                 |
| [workbook.Version = ExcelVersion.Excel2007;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                 |
| [// Stream the workbook to the client browser.]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                 |
| [workbook.SaveAs(\"Sample.xlsx\", Response, ExcelDownloadType.Open);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\] ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                         |
|                                                                                                                                               |
| [workbook.Version = ExcelVersion.Excel2007]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                               |
| [\'Stream the workbook to the client browser.]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                               |
| [workbook.SaveAs(\"Sample.xlsx\",Response,ExcelDownloadType.Open);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------+

 

Following code snippet allows to prompt for the Save dialog box, to save the created file in some location in disk.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                         |
|                                                                                                                                                                                 |
| [// Stream the workbook to the client browser.]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                 |
| [workbook.SaveAs(\"Sample.xls\", ExcelSaveType.SaveAsXLS, Response, ExcelDownloadType.PromptDialog);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\] ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                          |
|                                                                                                                                                                                |
| [\'Stream the workbook to the client browser.]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                |
| [workbook.SaveAs(\"Sample.xls\", ExcelSaveType.SaveAsXLS, Response, ExcelDownloadType.PromptDialog)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

For more information on overloads of the workbook\'s Save method, refer Class Reference in the online documentation.

This section explains saving the files to the below formats.

[]{#p26}**[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}** 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Excel97to2003](ms-xhelp:///?Id=c987ccb0-3e30-4c83-97d7-cc8c66c07ec4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}XLSX](ms-xhelp:///?Id=a73c7636-b4d4-4be4-ab0d-8c962207a3d5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SpreadsheetML](ms-xhelp:///?Id=b7fff239-e9ce-4e93-a227-8c570b114beb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}CSV Format](ms-xhelp:///?Id=b5f99653-905f-4aa8-a445-bc230a3d7b92){style="TEXT-DECORATION: none"}
::::
