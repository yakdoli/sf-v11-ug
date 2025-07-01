::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8480f90c-a622-4599-ae49-9d87f5d837e9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=066f02e8-b760-439b-84f2-90079907e4af){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=702d1cd4-b827-4e46-83f2-e25d649fc6e6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common](ms-xhelp:///?Id=204d4885-27f7-4e80-a9ba-4b2afe542a91){.d2h_breadcrumbsNormal}
:::

### How to set options to print Titles? {#how-to-set-options-to-print-titles style="tab-stops: 0pt"}

 

Printing Title Rows

 

The following code illustrates printing Title Rows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                     |
| [// Print Rows 1 to 3.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                           |
|                                                                                                                     |
| [sheet.PageSetup.PrintTitleRows = [\"\$A\$1:\$IV\$3\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                    |
| [\' Print Rows 1 to 3.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                          |
|                                                                                                                    |
| [sheet.PageSetup.PrintTitleRows = [\"\$A\$1:\$IV\$3\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Printing Title Columns

 

The following code illustrates printing Title Columns.

 

+---------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                            |
|                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                      |
|                                                                                                                           |
| [// Print Columns 1 to 3.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                              |
|                                                                                                                           |
| [sheet.PageSetup.PrintTitleColumns = [\"\$A\$1:\$C\$65536\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                          |
| [\' Print Columns 1 to 3.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                             |
|                                                                                                                          |
| [sheet.PageSetup.PrintTitleColumns = [\"\$A\$1:\$C\$65536\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------+

 

For information on Print settings, refer to section [4.3.3.1 Print Settings](ms-xhelp:///?Id=6c233f91-a7b5-49e0-9e7c-83e1fe127e7b).

 

[]{#related-topics}
::::
