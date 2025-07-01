::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=62aefe41-8f1a-4067-a820-8a2339080e94){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d30a01da-c68e-47ac-98fc-9ff20322cd3c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Inside CalcEngine](ms-xhelp:///?Id=62aefe41-8f1a-4067-a820-8a2339080e94){.d2h_breadcrumbsNormal}
:::

### Tracking the Information {#tracking-the-information style="tab-stops: 0pt"}

 

To track information used during calculations, **CalcEngine** manages several hash tables. Here is a table of the public hash tables in CalcEngine and a description of their keys and values:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 12: Hash Table

::: {align="center"}
  ----------------------- ------------------------ -------------------------- -----------------------------------------------------------------------
  Hash Table              Key                      Value                      Description
  FormulaInfoTable        Cell reference           FormulaInfo object         Tracks formula/value information for this cell[.]{style="COLOR: red"}
  DependentCells          Cell reference           Hashtable object           Tracks cells that depend on this cell.
  DependentFormulaCells   Formula cell reference   Hashtable object           Tracks cells that the formula cell depends upon.
  NamedRanges             Name string              Value string               Associates the named range with its value.
  LibraryFunctions        Function name            LibraryFunction delegate   Associates the function name with its method.
  ----------------------- ------------------------ -------------------------- -----------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Within CalcEngine, all data is assumed to be part of a rectangular array reference through cell coordinates like A1, C18, and so on. Even **CalcQuickBase** does not require or use such cell-type notation internally on the user side. When it communicates with CalcEngine, it converts its \[name\]-type notation into cell references that CalcEngine can understand. It is these cell references that are used as keys for the first three listed hash tables.

 

[]{#related-topics}
:::::
