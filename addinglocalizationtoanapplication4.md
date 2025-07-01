::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=1f3d07af-0e46-4526-a0bb-9ec7cff4768a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f9fff504-ad74-453d-8970-cdc5bb134ed1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET](ms-xhelp:///?Id=99c6694e-59c3-4c59-abb5-ce9ce9a948bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Client]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=01073408-6fb5-4943-a653-da9fd3358a53){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Localization](ms-xhelp:///?Id=1f3d07af-0e46-4526-a0bb-9ec7cff4768a){.d2h_breadcrumbsNormal}
:::

### Adding Localization to an Application {#adding-localization-to-an-application style="tab-stops: 0pt"}

Localization can be achieved by following the steps given below:

1.   OlapClient localization is fully based on the resource (.resx) file generation. Prepare the translated version the strings tabulated below and update it in the resource (.resx) files.

[]{style="COLOR: #c00000"} 

OlapClient:

 

::: {align="center"}
  ------------------------------------------------------------------------------------------------------------ -------------------------------------------------------------------------------------------------------------------
  [Localization Key]{style="COLOR: white; FONT-WEIGHT: normal"}[]{style="COLOR: white; FONT-WEIGHT: normal"}   [Strings to be localized]{style="COLOR: white; FONT-WEIGHT: normal"}[]{style="COLOR: white; FONT-WEIGHT: normal"}
  Categorical                                                                                                  Categorical
  CategoricalPage                                                                                              Categorical Page
  Chart                                                                                                        Chart
  CubeDimensionBrowser                                                                                         Cube Dimension Browser
  CubeSelector                                                                                                 Cube Selector
  Dialog_AddNewReport                                                                                          Add New Report
  Dialog_Cancel                                                                                                Cancel
  Dialog_ColumnPageSize                                                                                        Column Page Size
  Dialog_ConnectOption                                                                                         Connect Option
  Dialog_CreateNewReport                                                                                       Create New Report
  Dialog_DatabaseName                                                                                          Database Name
  Dialog_ElementsEditor                                                                                        Elements Editor
  Dialog_LoadReport                                                                                            Load Report
  Dialog_MDXQuery                                                                                              MDX Query
  Dialog_OK                                                                                                    OK
  Dialog_PagerSettings                                                                                         Pager Settings
  Dialog_RenameReport                                                                                          Rename Report
  Dialog_ReportName                                                                                            Report Name
  Dialog_RowPageSize                                                                                           Row Page Size
  Dialog_ServerName                                                                                            Server Name
  Expanding                                                                                                    Expanding\...
  Grid                                                                                                         Grid
  Loading                                                                                                      Loading\...
  Measures                                                                                                     Measures
  Report                                                                                                       Report
  Series                                                                                                       Series
  SeriesPage                                                                                                   Series Page
  Slicer                                                                                                       Slicer
  ToolTip_AddNewReport                                                                                         Add a New Report
  ToolTip_AutoExecute                                                                                          AutoExecute
  ToolTip_CheckAll                                                                                             Check All
  ToolTip_ConnectOption                                                                                        Connect Option
  ToolTip_CreateNewReport                                                                                      Create New Report
  ToolTip_Enable3DView                                                                                         Enable 3D View
  ToolTip_EnableDisablePaging                                                                                  Enable / Disable Paging
  ToolTip_ExcelLikeLayout                                                                                      Excel-Like Layout
  ToolTip_ExportToExcel                                                                                        Export To Excel
  ToolTip_ExportToPDF                                                                                          Export To PDF
  ToolTip_ExportToWord                                                                                         Export To Word
  ToolTip_LegendTypes                                                                                          Legend Types
  ToolTip_LoadSavedReport                                                                                      Load Saved Report
  ToolTip_NormalLayout                                                                                         Normal
  ToolTip_NoSummariesLayout                                                                                    No Summaries
  ToolTip_PagerOptions                                                                                         Pager Options
  ToolTip_RemoveSelectedReport                                                                                 Remove the Selected Report
  ToolTip_RenameSelectedReport                                                                                 Rename the Selected Report
  ToolTip_ReportList                                                                                           ReportList
  ToolTip_SaveCurrentReport                                                                                    Save the Current Report
  ToolTip_SelectChartTypes                                                                                     Select Chart Types
  ToolTip_ShowHeaderCellTooltip                                                                                Show HeaderCell ToolTip
  ToolTip_ShowHyperlinkCells                                                                                   Show Hyperlink Cells
  ToolTip_ShowLegends                                                                                          Show Legends
  ToolTip_ShowMDX                                                                                              Show MDX
  ToolTip_UncheckAll                                                                                           Uncheck All
  ------------------------------------------------------------------------------------------------------------ -------------------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #c00000"} 

OlapGrid

::: {align="center"}
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------- ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [Localization Key]{style="COLOR: white; FONT-WEIGHT: normal"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: white; FONT-SIZE: 12pt; FONT-WEIGHT: normal"}   [Strings to be localized]{style="COLOR: white; FONT-WEIGHT: normal"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: white; FONT-SIZE: 12pt; FONT-WEIGHT: normal"}
  Dialog_AddNew                                                                                                                                                         Add New
  Dialog_BackColor                                                                                                                                                      Back Color
  Dialog_Between                                                                                                                                                        Between
  Dialog_BorderColor                                                                                                                                                    Border Color
  Dialog_BorderStyle                                                                                                                                                    Border Style
  Dialog_BorderWidth                                                                                                                                                    Border Width
  Dialog_Cancel                                                                                                                                                         Cancel
  Dialog_Condition                                                                                                                                                      Condition
  Dialog_ConditionalFormatting                                                                                                                                          Conditional Formatting
  Dialog_ConditionType                                                                                                                                                  Condition Type
  Dialog_EditCondition                                                                                                                                                  Edit Condition
  Dialog_Equal                                                                                                                                                          Equal
  Dialog_Font                                                                                                                                                           Font
  Dialog_FontSize                                                                                                                                                       Font Size
  Dialog_Format                                                                                                                                                         Format
  Dialog_Greater                                                                                                                                                        Greater
  Dialog_Lesser                                                                                                                                                         Lesser
  Dialog_Measure                                                                                                                                                        Measure
  Dialog_NotBetween                                                                                                                                                     Not Between
  Dialog_NotEqual                                                                                                                                                       Not Equal
  Dialog_Ok                                                                                                                                                             OK
  Dialog_Operand                                                                                                                                                        Operand
  Dialog_Padding                                                                                                                                                        Padding
  Dialog_Remove                                                                                                                                                         Remove
  Dialog_Reset                                                                                                                                                          Reset
  Dialog_Style                                                                                                                                                          Style
  ToolTip_ApplyFormatting                                                                                                                                               Apply Formatting
  ToolTip_ClearFormatting                                                                                                                                               Clear Formatting
  ToolTip_Column                                                                                                                                                        Column
  ToolTip_ExcelLikeLayout                                                                                                                                               Excel Like Layout
  ToolTip_NormalLayout                                                                                                                                                  Normal Layout
  ToolTip_NormalTopSummaryLayout                                                                                                                                        Normal Top Summary Layout
  ToolTip_NoSummariesLayout                                                                                                                                             No Summaries Layout
  ToolTip_Row                                                                                                                                                           Row
  ToolTip_ShowHideHeaderCellToolTip                                                                                                                                     Show/Hide Header Cell ToolTip
  ToolTip_ShowHideValueCellToolTip                                                                                                                                      Show/Hide Value Cell ToolTip
  ToolTip_Value                                                                                                                                                         Value
  --------------------------------------------------------------------------------------------------------------------------------------------------------------------- ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

2.   Name the resource files as "**OlapClient.*\<locale string representation\>*.resx**" and "**OlapGrid.*\<locale string representation\>*.resx**". For example, French culture can be written as *"OlapClient.fr-FR.resx" and* *"OlapGrid.fr-FR.resx"* and place the resource files in the "App_GlobalResources" folder of the web site.

3.   Change the culture setting of the web page through OlapDataManger by using the following code:

**** 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[CS\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                    |
|                                                                                                                                                                                                        |
| [var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapDataManager = [new]{style="COLOR: blue"} [OlapDataManager]{style="COLOR: #2b91af"}(connectionString);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [olapDataManager.Culture = [new]{style="COLOR: blue"} System.Globalization.[CultureInfo]{style="COLOR: #2b91af"}([\"fr-FR\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                        |
| [olapDataManager.OverrideDefaultFormatStrings = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapClient1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapClient1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 10.5pt"}                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                   |
|                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapDataManager = [New ]{style="COLOR: blue"}[OlapDataManager]{style="COLOR: #2b91af"}(connectionString)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                       |
| [olapDataManager.Culture = [New]{style="COLOR: blue"} System.Globalization.[CultureInfo]{style="COLOR: #2b91af"}([\"fr-FR\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                       |
| [olapDataManager.OverrideDefaultFormatStrings = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                       |
| [Me.OlapClient1.OlapDataManager = olapDataManager]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                       |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapClient1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 10.5pt"}                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
::::::
