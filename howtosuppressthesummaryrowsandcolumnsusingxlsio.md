::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=11f1bd2a-7a8a-4b92-8c82-2f7bc6fb4a76){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ad80cb72-08a0-40ad-9a18-baf80caf8624){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=702d1cd4-b827-4e46-83f2-e25d649fc6e6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Advanced](ms-xhelp:///?Id=bc97b4a0-6ec2-4fb4-bdb2-dd1c9dbb3431){.d2h_breadcrumbsNormal}
:::

### How to suppress the summary rows and columns using XlsIO? {#how-to-suppress-the-summary-rows-and-columns-using-xlsio style="tab-stops: 0pt"}

 

You can suppress the summary rows and columns by using the IsSummaryRowBelow and IsSummaryColumnRight properties. The following code example illustrates this.

 

+------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                       |
|                                                                                                            |
| [// Suppress the summary rows at the bottom.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}            |
|                                                                                                            |
| [sheet.PageSetup.IsSummaryRowBelow = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                            |
| [// Suppress the summary columns to the right.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}          |
|                                                                                                            |
| [sheet.PageSetup.IsSummaryColumnRight = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                      |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [\' Suppress the summary rows at the bottom.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}           |
|                                                                                                           |
| [sheet.PageSetup.IsSummaryRowBelow = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                           |
| [\' Suppress the summary columns to the right.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}         |
|                                                                                                           |
| [sheet.PageSetup.IsSummaryColumnRight = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
