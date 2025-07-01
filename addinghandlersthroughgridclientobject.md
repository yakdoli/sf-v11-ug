::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=46fa805d-7bc5-4e1d-9efe-50949e2973f9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=01f6accd-1877-4336-8c77-8037d7c5dfe8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Client-Side Events and Methods](ms-xhelp:///?Id=a04b3f42-5102-444d-9d48-83d2d985ac5d){.d2h_breadcrumbsNormal}
:::

### Adding Handlers through Grid Client Object: {#adding-handlers-through-grid-client-object style="tab-stops: 0pt"}

 

The following code snippet illustrates adding handlers in client script.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                        |
| [    var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ gridObj = \$find([\"Grid1\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                        |
| **[           gridObj.add_OnRowHover(OnRecordHover);]{style="FONT-FAMILY: 'Courier New'"}**                                                            |
|                                                                                                                                                        |
| **[           gridObj.add_OnRowSelect(OnRecordSelect);]{style="FONT-FAMILY: 'Courier New'"}**                                                          |
|                                                                                                                                                        |
| **[           gridObj.add_OnDoubleClick(OnRecordDoubleClick);]{style="FONT-FAMILY: 'Courier New'"}**                                                   |
|                                                                                                                                                        |
| **[           gridObj.add_OnRecordsUnselectionEvent(OnRecordUnSelect);]{style="FONT-FAMILY: 'Courier New'"}**                                          |
|                                                                                                                                                        |
| **[           gridObj.add_OnLoad(OnLoad);           ]{style="FONT-FAMILY: 'Courier New'"}**                                                            |
|                                                                                                                                                        |
| **[           gridObj.add_OnActionBegin(OnBegin);]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                                                        |
| **[           gridObj.add_OnActionSuccess(OnSuccess);]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                                                                        |
| **[           gridObj.add_OnActionFailure(OnFailure);]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                                                                        |
| **[           gridObj.add_OnRowsSelected(OnRowsSelected);]{style="FONT-FAMILY: 'Courier New'"}**                                                       |
|                                                                                                                                                        |
| **[           gridObj.add_OnDroppingTarget(OnRecordSelect);]{style="FONT-FAMILY: 'Courier New'"}**                                                     |
|                                                                                                                                                        |
| **[           gridObj.add_OnDropTargetCompleted(OnDropped);]{style="FONT-FAMILY: 'Courier New'"}**                                                     |
|                                                                                                                                                        |
| **[           gridObj.add_OnDroponGridRowsEvent(OnGridRowDrag);]{style="FONT-FAMILY: 'Courier New'"}**                                                 |
|                                                                                                                                                        |
| **[           gridObj.add_OnDragonGridRowEvent(OnGridrowsDrop);]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::
