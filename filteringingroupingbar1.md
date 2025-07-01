::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=907ed9d1-673d-427d-8e31-331e488d04ab){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4df4e839-82fc-437d-9409-3ae5cc396f89){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Windows](ms-xhelp:///?Id=af2b5ead-c104-4cdd-b5e2-2b2aee61afe3){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4c7c53bf-fd09-4600-aaf4-4f09cc0f9359){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grouping Bar](ms-xhelp:///?Id=907ed9d1-673d-427d-8e31-331e488d04ab){.d2h_breadcrumbsNormal}
:::

### Filtering in Grouping Bar {#filtering-in-grouping-bar style="tab-stops: 0pt"}

Data filtering displays only a subset of data that meets criteria specified by you and hides data that you don't want to be displayed. The items present in the filter header area, column header area and row header area, provide the option of run-time filtering which is represented as a funnel symbol on it. On clicking the symbol, it opens a filter popup which displays a list of elements through which filtering can be applied.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![Description: C:\\Users\\dwarageshmb\\Desktop\\Vol 4 Docs\\Images\\Filter Popup.png](ImagesExt/image112_12.jpg){border="0"}

Figure 10: Filter Popup

 

The following code example illustrates how to disable the filtering in the Grouping Bar.

 

+-------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                               |
| [// Disabling Filtering]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                               |
| [pivotGridControl1.AllowFiltering = [false]{style="COLOR: blue"};[]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                      |
| [// Disabling Filtering]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}**[]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                      |
| [pivotGridControl1.AllowFiltering = [False]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                               |
+----------------------------------------------------------------------------------------------------------------------+

[[]{style="TEXT-DECORATION: none"}]{.underline} 

[]{#related-topics}
::::
