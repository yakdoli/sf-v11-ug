::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=919156eb-202b-440b-aee0-107d9f8589ce){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6a593407-7c45-4c0a-98e0-797dd2d71dde){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Report Viewer](ms-xhelp:///?Id=35081cc7-4b81-4ef5-97d2-894ad584b907){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Report Viewer Silverlight]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=7a4490f0-f444-4f6b-b376-4bba56a9eb03){.d2h_breadcrumbsNormal}
:::

## Members {#members style="TEXT-ALIGN: justify; tab-stops: 0pt"}

**[Properties]{style="FONT-SIZE: 12pt"}**

Table 4: Properties Table**[]{style="FONT-SIZE: 12pt"}**

::: {align="center"}
  ---------------------------- ----------------------------------------------------------------------------------------- --------------------- ----------------------------
  **Property**                 **Description**                                                                           **Type**              **Data Type**
  DataSources                  Gets a collection of data sources used by the report.                                      -                    ReportDataSourceCollection
  CurrentPage                  Gets or sets the current page                                                             Dependency Property   Int
  ShowPrintButton              Gets or sets a value that indicates whether **Print** button is visible on the toolbar.   Dependency Property   Bool
  ShowRefreshButton            Gets or sets a value that indicates whether the **Refresh** button is visible.            Dependency Property   Bool
  ShowToolBar                  Gets or sets a value that indicates whether the toolbar is visible on the control.        Dependency Property   Bool
  ShowZoomControl              Gets or sets a value that indicates whether the **Zoom** list box is visible.             Dependency Property   Bool
  ViewMode                     Gets or sets a value that indicates whether it is Normal or Print View                    Dependency Property   Enum
  ShowPageNavigationControls   Get or set a value that indicates whether the Show navigationcontrols is visible          Dependency Property   Bool
  ---------------------------- ----------------------------------------------------------------------------------------- --------------------- ----------------------------
:::

 

**[Methods]{style="FONT-SIZE: 12pt"}**

Table 5: Methods Table**[]{style="FONT-SIZE: 12pt"}**

::: {align="center"}
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| **Method**      | **Description**                                       | **Parameters**               | **Return Type**               |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| RefreshReport   | Causes the local report to be rendered with new data. | [ ]{style="COLOR: #c00000"}- | Void                          |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| GetParameters   | Get the necessary parameters for the report           | \-                           | ReportParameterInfoCollection |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| GetTotalPage    | Gets the total pages of the report                    | \-                           | int                           |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| GetDataSetNames | Get the dataset names from the local report           | \-                           | IList\<string\>               |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| LoadReport      | Loads the local report for processing                 | Stream                       | void                          |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| Print           | Displays the **Print** dialog box.                    | \-                           | Void                          |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| ShowNormalView  | Displays the Normal view of the report                | \-                           | Void                          |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
+-----------------+-------------------------------------------------------+------------------------------+-------------------------------+
| SetParameters   | Set the necessary parameters for the report           | ReportParameter\[\]          | Void                          |
|                 |                                                       |                              |                               |
|                 |                                                       |                              |                               |
+=================+=======================================================+==============================+===============================+
:::

**[]{style="FONT-SIZE: 12pt"}** 

**[Events]{style="FONT-SIZE: 14pt"}**

Table 6: Events Table**[]{style="FONT-SIZE: 14pt"}**

::: {align="center"}
+-----------------------------------+---------------------------------------------------------------------------------+
| **Event**                         | **Description**                                                                 |
+-----------------------------------+---------------------------------------------------------------------------------+
| ViewModeChanged                   | The event is triggered when the view is changed to normal and print view        |
|                                   |                                                                                 |
|                                   |                                                                                 |
+-----------------------------------+---------------------------------------------------------------------------------+
| ViewButtonClick                   | The event is triggered when the view button is clicked                          |
|                                   |                                                                                 |
|                                   |                                                                                 |
+-----------------------------------+---------------------------------------------------------------------------------+
| SubreportProcessing               | The event will be triggered if the report is RDLC and contains with sub report. |
|                                   |                                                                                 |
|                                   |                                                                                 |
+===================================+=================================================================================+
:::

[]{#related-topics}
:::::::
