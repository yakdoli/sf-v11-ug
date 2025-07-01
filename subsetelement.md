::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4f2ae716-5e72-4dac-8e82-3d7e65215ad2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=562b7f78-163e-443e-b9a1-1368d57cf97a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OlapReport](ms-xhelp:///?Id=5df0d4a2-dd21-4743-9142-c97b5f6c86e0){.d2h_breadcrumbsNormal}
:::

### Subset Element {#subset-element style="tab-stops: 0pt"}

Subset Elements are used to filter the result set by their count. It will just filter the number records and number of fields in the result set.

The following codes will illustrate the creation of a Subset Element:

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]                                                  ]{style="FONT-FAMILY: 'Courier New'"}**                                                                 |
|                                                                                                                                                                    |
| [SubsetElement]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ subSetElementColumn = [new]{style="COLOR: blue"} [SubsetElement]{style="COLOR: #2b91af"}(5);\ |
| subSetElementColumn.Name = [\"Top 5 Elements\"]{style="COLOR: #a31515"};\                                                                                          |
| [SubsetElement]{style="COLOR: #2b91af"} subSetElementRow = [new]{style="COLOR: blue"} [SubsetElement]{style="COLOR: #2b91af"}(3);\                                 |
| subSetElementRow.Name = [\"Top 3 Elements\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                    |
| [olapReport.CategoricalElements.SubSetElement = subSetElementColumn;]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                    |
| [olapReport.SeriesElements.SubSetElement = subSetElementRow;]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ subSetElementColumn [As]{style="COLOR: blue"} SubsetElement = [New]{style="COLOR: blue"} SubsetElement(5)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [subSetElementColumn.Name = ]{style="FONT-FAMILY: 'Courier New'"}[\"Top 5 Elements\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ subSetElementRow [As]{style="COLOR: blue"} SubsetElement = [New]{style="COLOR: blue"} SubsetElement(3)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                        |
| [subSetElementRow.Name = ]{style="FONT-FAMILY: 'Courier New'"}[\"Top 3 Elements\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                        |
| [olapReport.CategoricalElements.SubSetElement = subSetElementColumn]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                        |
| [olapReport.SeriesElements.SubSetElement = subSetElementRow]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
