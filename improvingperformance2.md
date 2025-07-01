::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3fa02d4c-af44-483e-888a-7af380b7fc2f){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2640fcac-ff84-46c8-b840-ce041972b57e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=ad99231a-9920-49c5-b9a3-8c0224163396){.d2h_breadcrumbsNormal}
:::

## Improving Performance {#improving-performance style="tab-stops: 0pt"}

 

Essential XlsIO can create large reports in few seconds.

 

![](ImagesExt/image47_34.jpg){border="0"}**Tips to improve the Performance**

 

[·      ]{style="FONT-FAMILY: Symbol"}Use [[default styles]{.UGHyperlink}](ms-xhelp:///?Id=e3e17bbe-6827-4671-baed-5aa5f4620ffb), which can be used to apply styles for the whole column instead of having to apply for each cell.

[·      ]{style="FONT-FAMILY: Symbol"}Minimize AutoFit manipulations.

[·      ]{style="FONT-FAMILY: Symbol"}Get **UsedRange** globally. It is recommended to get the UsedRange in loops as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                              |
|                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                          |
|                                                                                                                                                               |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[([int]{style="COLOR: blue"} i = 0;i\<sheet.UsedRange.LastRow;i++)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                               |
| [// Do not use the following method.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                       |
|                                                                                                                                                               |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lastRow = sheet.UsedRange.LastRow]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                               |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[([int]{style="COLOR: blue"} i=0;i\<lastRow;i++)]{style="FONT-FAMILY: 'Courier New'"}                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

[·      ]{style="FONT-FAMILY: Symbol"}Use [[IMigrantRange]{.UGHyperlink}](ms-xhelp:///?Id=b98d74ad-3c05-4b04-b9ba-63c315398cdb) to optimize memory performance while dealing with large strings.

[·      ]{style="FONT-FAMILY: Symbol"}Use [[global styles]{.UGHyperlink}](ms-xhelp:///?Id=e3e17bbe-6827-4671-baed-5aa5f4620ffb), rather than using different cell styles for each cell/range.

[·      ]{style="FONT-FAMILY: Symbol"}Use **Begin** and **End** call while using more than one global style for a worksheet.

[·      ]{style="FONT-FAMILY: Symbol"}Use **Value** and **Value2** property only when the data type is unknown. Value/Value2 property checks the data type of the given string and hence this consumes time.

[·      ]{style="FONT-FAMILY: Symbol"}Files parsing can be optimized by setting **IApplication.UseFastRecordParsing** = **false** or **true** (true -- fast mode, but less error checks and false -- slower but more reliable).

[·      ]{style="FONT-FAMILY: Symbol"}To extract values little faster, use **Unsafe** code option of **IApplication** interface as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                          |
|                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                      |
|                                                                                                                           |
| [application.DataProviderType = [ExcelDataProviderType]{style="COLOR: teal"}.Unsafe;]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Make use of **GetText**, **SetText**, **GetNumber** and **SetNumber** methods that enable users to get/set values without range object.

[·      ]{style="FONT-FAMILY: Symbol"}Set **IWorkbook.DetectDateTimeInValue** property to **false** with Value2 property, if you are sure that the given value is not of **DateTime** data type which improves time performance.

[·      ]{style="FONT-FAMILY: Symbol"}Use of **BeginUpdate** and **EndUpdate** methods for large blocks of Data Validation greatly improves the performance.

[·      ]{style="FONT-FAMILY: Symbol"}Use **DataProvider.Unsafe** option to increase performance while deleting large number of rows or columns.

[·      ]{style="FONT-FAMILY: Symbol"}Use [[CompressionLevel]{.UGHyperlink}](ms-xhelp:///?Id=6e54acab-7fec-462f-a558-8e52de354beb) to reduce the size of the file.

 

[]{#p32} 

[]{#related-topics}
::::
