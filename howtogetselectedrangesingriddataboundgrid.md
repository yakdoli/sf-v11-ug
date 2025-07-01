::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=68d60bcd-4de7-4644-8404-a968c63ab547){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3d26f05d-1249-4122-a610-9bf3c32037b2){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=28ff22ed-2523-4bf9-8f6c-4d94f7bcabcc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[GridDataBoundGrid](ms-xhelp:///?Id=30fe9928-71fa-4ef0-b646-e928f383ee64){.d2h_breadcrumbsNormal}
:::

### How to Get Selected Ranges in GridDataBoundGrid {#how-to-get-selected-ranges-in-griddataboundgrid style="tab-stops: 0pt"}

 

To get the selected range of cells, use the **GetSelectedRanges** method .It returns the list with selected cells. This method has two arguments,

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ranges** - It gets the range of cells to be selected.

[·      ]{style="FONT-FAMILY: Symbol"}**ConsiderCurrentCell**

**True** -  If current cell should be treated as selected range.

 

Example

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                              |
| **[      ]{style="FONT-FAMILY: 'Courier New'"}**[GridRangeInfoList rangeList = [null]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                              |
| [      [this]{style="COLOR: blue"}.gridDataBoundGrid1.Selections.GetSelectedRanges([out                 ]{style="COLOR: blue"}rangeList, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| [      [if]{style="COLOR: blue"} (rangeList.Count \> 0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                              |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                              |
| [            [foreach]{style="COLOR: blue"} (GridRangeInfo range [in]{style="COLOR: blue"} rangeList)]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                              |
| [                  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                              |
| [                  [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} row = range.Top; row \<= range.Bottom; ++row)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                              |
| [                        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                              |
| [                        [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} col = range.Top; col \<= range.Bottom; ++col)]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                              |
| [                                      {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                              |
| [                                    Console.WriteLine(String.Format([\"Cell {0}, {1} selected\"]{style="COLOR: #a31515"}, row, col));]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                                              |
| [                                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                              |
| [                  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                              |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                              |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                              |
|                                                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

[                ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rangeList [As]{style="COLOR: blue"} GridRangeInfoList = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [            [Me]{style="COLOR: blue"}.gridDataBoundGrid1.Selections.GetSelectedRanges(rangeList,[False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [            [If]{style="COLOR: blue"} rangeList.Count \> 0 [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [                  [For]{style="COLOR: blue"} [Each]{style="COLOR: blue"} range [As]{style="COLOR: blue"} GridRangeInfo [In]{style="COLOR: blue"} rangeList                                              [For]{style="COLOR: blue"} row [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = range.Top [To]{style="COLOR: blue"} range.Bottom]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [                              [For]{style="COLOR: blue"} col [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = range.Left [To]{style="COLOR: blue"} range.Right]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [                                    Console.WriteLine([String]{style="COLOR: blue"}.Format([\"Cell {0}, {1} selected\"]{style="COLOR: #a31515"}, row, col))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [                              [Next]{style="COLOR: blue"} col]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [                        [Next]{style="COLOR: blue"} row]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [                  [Next]{style="COLOR: blue"} range]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [            [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[                ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[      ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}

[]{#related-topics}
::::
