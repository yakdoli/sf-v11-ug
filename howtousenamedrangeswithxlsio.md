::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d8cf0278-68bc-453b-973d-b7bb1d6dde71){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2e48fb6a-77fb-47f2-8bf0-c58110a4b4fd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=702d1cd4-b827-4e46-83f2-e25d649fc6e6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=204d4885-27f7-4e80-a9ba-4b2afe542a91){.d2h_breadcrumbsNormal}
:::

### How to use Named Ranges with XlsIO? {#how-to-use-named-ranges-with-xlsio style="tab-stops: 0pt"}

**[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"}** 

The **NamedRanges** collection belongs to the workbook, and not to the worksheet. If you define two named ranges with the same name, then the named range that is defined last will replace the previous named range.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                             |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [// Looping through the Named Ranges in a spreadsheet.  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                  |
|                                                                                                                                                                              |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([IName]{style="COLOR: teal"} name [in]{style="COLOR: blue"} mySheet.Names)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                              |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Show(name.Name.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [// There is already a named range called \"One\", I am changing the address that it points to. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                          |
|                                                                                                                                                                              |
| [mySheet.Names\[[\"One\"]{style="COLOR: maroon"}\].RefersToRange = mySheet.Range\[[\"B6\"]{style="COLOR: maroon"}\];]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [// Named ranges are added to the workbook collection in both the methods mentioned below. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                               |
|                                                                                                                                                                              |
| [// Adding the named Range to the workbook.  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                              |
| [myWorkbook.Names.Add([\"TestRangeBook\"]{style="COLOR: maroon"}, mySheet.Range\[[\"A5\"]{style="COLOR: maroon"}\]);]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [// Adding the named Range to the workbook. Internally named range is added to the workbook names coll.  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                 |
|                                                                                                                                                                              |
| [mySheet.Names.Add([\"TestRangeSheet\"]{style="COLOR: maroon"}, mySheet.Range\[[\"A5\"]{style="COLOR: maroon"}\]);]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [// Referencing from the sheet. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                              |
| [mySheet.Range\[[\"TestRangeSheet\"]{style="COLOR: maroon"}\].Number = 100;]{style="FONT-FAMILY: 'Courier New'"}                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [\' Looping through the Named Ranges in a spreadsheet. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                            |
|                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ name [As]{style="COLOR: blue"} Syncfusion.XlsIO.IName]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                       |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Each]{style="COLOR: blue"} name [In]{style="COLOR: blue"} mySheet.Names]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                       |
| [MessageBox.Show(name.Name.ToString()) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                       |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ name]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [\' There is already a named range called \"One\", I am changing the address that it points to.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                    |
|                                                                                                                                                                       |
| [mySheet.Names([\"One\"]{style="COLOR: maroon"}).RefersToRange = mySheet.Range([\"B6\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [\' Named ranges are added to the workbook collection in both the methods mentioned below.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                         |
|                                                                                                                                                                       |
| [\' Adding the named Range to the workbook.  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                      |
|                                                                                                                                                                       |
| [myWorkbook.Names.Add([\"TestRangeBook\"]{style="COLOR: maroon"}, mySheet.Range([\"A5\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [\' Adding the named Range to the workbook. Internally named range is added to the workbook names coll. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}           |
|                                                                                                                                                                       |
| [mySheet.Names.Add([\"TestRangeSheet\"]{style="COLOR: maroon"}, mySheet.Range([\"A5\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [\' Referencing from the sheet.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                    |
|                                                                                                                                                                       |
| [mySheet.Range([\"TestRangeSheet\"]{style="COLOR: maroon"}).Number = 100]{style="FONT-FAMILY: 'Courier New'"}                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
