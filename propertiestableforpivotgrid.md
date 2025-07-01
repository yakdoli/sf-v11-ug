::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=335eda42-8815-4ede-b550-e0e02c37693f){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c7067d45-1ede-4998-9adf-01fb91a67226){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pivot Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=de8e8ba5-5ab5-40b8-9195-9f26c729e7a2){.d2h_breadcrumbsNormal}
:::

## Properties Table for PivotGrid {#properties-table-for-pivotgrid style="tab-stops: 0pt"}

 

Table 5: Properties Table

::: {align="center"}
  ----------------------------------------------------- ----------------------------------------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Property Name                                         Type                                      Description
  DeferLayoutUpdate****                                 bool****                                  Gets or sets a value to specify whether the layout should be updated immediately after updating the pivoting info, or if it should wait for a *Refresh()* call.[]{style="COLOR: #c00000"}
  FreezeHeaders[]{style="COLOR: #c00000"}               bool[]{style="COLOR: #c00000"}            Gets or sets a value to specify whether headers of a grid has to be frozen or not.[]{style="COLOR: #c00000"}
  DataSource[]{style="COLOR: #c00000"}                  object[]{style="COLOR: #c00000"}          Gets or sets the source of data for a pivot table. This object should be an IEnumerable or IQueryable list.[]{style="COLOR: #c00000"}
  PivotCalculations[]{style="COLOR: #c00000"}           Hashtable[]{style="COLOR: #c00000"}       Gets the collection of Pivot Calculations.[]{style="COLOR: #c00000"}
  PivotColumns[]{style="COLOR: #c00000"}                Hashtable[]{style="COLOR: #c00000"}       Gets the collection of pivot columns.[]{style="COLOR: #c00000"}
  PivotEngine[]{style="COLOR: #c00000"}                 PivotEngine[]{style="COLOR: #c00000"}     Gets or sets the pivot engine for a grid.[]{style="COLOR: #c00000"}
  PivotRows[]{style="COLOR: #c00000"}                   Hashtable[]{style="COLOR: #c00000"}       Gets the collection of pivot rows.[]{style="COLOR: #c00000"}
  ShowCalculationsAsColumns[]{style="COLOR: #c00000"}   bool[]{style="COLOR: #c00000"}            Gets or sets a value to specify whether calculations should appear as rows or columns. The default behavior is for calculations to appear as columns.[]{style="COLOR: #c00000"}
  ShowGrandTotals[]{style="COLOR: #c00000"}             bool[]{style="COLOR: #c00000"}            Gets or sets a value to specify whether grand total calculations should be computed by the engine.[]{style="COLOR: #c00000"}
  PivotCellInfo[]{style="COLOR: #c00000"}               PivotCellInfo[]{style="COLOR: #c00000"}   Gets or sets the PivotCellInfo in order to check the cell type.[]{style="COLOR: #c00000"}
  ----------------------------------------------------- ----------------------------------------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{#related-topics}
:::::
