::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4f620f2b-a01a-4753-93bb-557140c963bc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bc33f037-4019-4458-9f75-8f1fc96f167c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=28ff22ed-2523-4bf9-8f6c-4d94f7bcabcc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Common to GridControl, GridDataBoundGrid and GridGrouping](ms-xhelp:///?Id=d7132129-5014-47d6-9419-88a1e83d196a){.d2h_breadcrumbsNormal}
:::

### How to Get the Top / Bottom / Left / Right Viewable Row and Column Indexes {#how-to-get-the-top-bottom-left-right-viewable-row-and-column-indexes style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Introduction

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Use the following variables to get the viewable row and column indexes.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                               |
| []{style="COLOR: black"}                                                                                                                                                                      |
|                                                                                                                                                                                               |
| [// Top Row Index]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.TopRowIndex]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                  |
|                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                          |
|                                                                                                                                                                                               |
| [// Left Column Index\                                                                                                                                                                        |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.LeftColIndex]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}              |
|                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                          |
|                                                                                                                                                                                               |
| [// Bottom Row Index\                                                                                                                                                                         |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.ViewLayout.LastVisibleRow]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                          |
|                                                                                                                                                                                               |
| [// Right Column Index\                                                                                                                                                                       |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.ViewLayout.LastVisibleCol]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                          |
|                                                                                                                                                                                             |
| []{style="COLOR: black"}                                                                                                                                                                    |
|                                                                                                                                                                                             |
| [\' Top Row Index\                                                                                                                                                                          |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.TopRowIndex]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}               |
|                                                                                                                                                                                             |
| [\                                                                                                                                                                                          |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\' Left Column Index\                                                                                                                   |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.LeftColIndex\                                                                |
| \                                                                                                                                                                                           |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\' Bottom Row Index\                                                                                                                    |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.ViewLayout.LastVisibleRow\                                                   |
| \                                                                                                                                                                                           |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[\' Right Column Index\                                                                                                                  |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.ViewLayout.LastVisibleCol]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p622} 

 

[]{#related-topics}
::::
