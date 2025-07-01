::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=76112122-6424-48ca-9508-d0a4eea9af2e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=29977b58-da3c-4ba4-bb98-877432d4172f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=21b26556-5905-4ad9-90b4-40320db25faf){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Page Layout](ms-xhelp:///?Id=76112122-6424-48ca-9508-d0a4eea9af2e){.d2h_breadcrumbsNormal}
:::

### Page Setup {#page-setup style="tab-stops: 0pt"}

 

In MS Excel, the way the spreadsheet fits onto paper can be controlled through the **Page Setup** dialog box. You can select the size and orientation of the paper, the width of the margins, what goes into the header and footer of each page, and the order of printing cells for sheets that will take several pieces of paper.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: Though the sample code uses sheet object, it is possible to read/write page setup options for chart worksheet and embedded chart using IChartPageSetup interface.
:::

 

There may also be a need to change the first page number, which starts with \'1\', by default. This can be done through the page number customization options provided by the Page Setup dialog box.

 

+-----------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                          |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [sheet.PageSetup.AutoFirstPageNumber = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                           |
| [sheet.PageSetup.FirstPageNumber = 2;]{style="FONT-FAMILY: 'Courier New'"}                                |
+-----------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                      |
|                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                           |
| [sheet.PageSetup.AutoFirstPageNumber = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                           |
| [sheet.PageSetup.FirstPageNumber = 2;]{style="FONT-FAMILY: 'Courier New'"}                                |
+-----------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Following topics explain how various other page setup options can be set by using XlsIO.

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Margins](ms-xhelp:///?Id=53b77cf3-95b4-416d-8eeb-31dcd098db4e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Orientation](ms-xhelp:///?Id=be51b1d9-0fba-4536-9b77-d57c58bd9b14){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Paper Size](ms-xhelp:///?Id=2160515e-d4f2-4e55-867b-56b3d92d88c9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Breaks](ms-xhelp:///?Id=e1db5290-3a2c-4a49-ad0e-a01a11c51cb3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Background](ms-xhelp:///?Id=eb7775f3-7e4a-482e-b870-e457d99406fa){style="TEXT-DECORATION: none"}
:::::
