::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=06676280-4bc3-4450-a12c-f47c90a887f6){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=dad94e40-fcb3-49ac-9c37-9da6332489c9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=702d1cd4-b827-4e46-83f2-e25d649fc6e6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=204d4885-27f7-4e80-a9ba-4b2afe542a91){.d2h_breadcrumbsNormal}
:::

### How to copy a range from one workbook to another? {#how-to-copy-a-range-from-one-workbook-to-another style="tab-stops: 0pt"}

 

The Range and CopyTo methods include overloads for copying the Source Worksheet range to the Destination Worksheet range. The following code example illustrates how to copy a range from one workbook to another workbook.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                 |
| [// The first worksheet object in the worksheets collection in the Source Workbook is accessed. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}             |
|                                                                                                                                                                 |
| [IWorksheet]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ SourceWorksheet = SourceWorkbook.Worksheets\[0\];]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                 |
| [// The first worksheet object in the worksheets collection in the Destination Workbook is accessed. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}        |
|                                                                                                                                                                 |
| [IWorksheet]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ DestinationWorksheet = DestinationWorkbook.Worksheets\[0\];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                 |
| [// Assigning an object to the range of cells (90 rows) both for source and destination.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                     |
|                                                                                                                                                                 |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ source = SourceWorksheet.Range\[1, 1, 90, 100\];]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                 |
| [IRange]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ des = DestinationWorksheet.Range\[1, 1, 90, 100\];]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                 |
| [// Copying (90 rows) from Source to Destination worksheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                  |
|                                                                                                                                                                 |
| [source.CopyTo(des);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                        |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [\' The first worksheet object in the worksheets collection in the Source Workbook is accessed. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                         |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ SourceWorksheet [As]{style="COLOR: blue"} Syncfusion.XlsIO.IWorksheet = SourceWorkbook.Worksheets(0)]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [\' The first worksheet object in the worksheets collection in the Destination Workbook is accessed. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                    |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DestinationWorksheet [As]{style="COLOR: blue"} Syncfusion.XlsIO.IWorksheet = DestinationWorkbook.Worksheets(0)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [\' Assigning an object to the range of cells (90 rows) both for source and destination. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ source [As]{style="COLOR: blue"} Syncfusion.XlsIO.IRange = SourceWorksheet.Range(1, 1, 90, 100)]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ des [As]{style="COLOR: blue"} Syncfusion.XlsIO.IRange = DestinationWorksheet.Range(1, 1, 90, 100)]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [\' Copying (90 rows) from Source to Destination worksheet. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                                             |
| [source.CopyTo(des)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
