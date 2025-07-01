::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=1a15ccf7-d241-47a4-bb20-13139c8b7b6a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4f2ae716-5e72-4dac-8e82-3d7e65215ad2){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OlapReport](ms-xhelp:///?Id=5df0d4a2-dd21-4743-9142-c97b5f6c86e0){.d2h_breadcrumbsNormal}
:::

### Sort Element {#sort-element style="tab-stops: 0pt"}

The result set can be sorted by using the **SortElement**. We can create Sort elements and add it to the **OlapReport**. There are four types of sorting orders. They are:

[·      ]{style="FONT-FAMILY: Symbol"}ASC -- Sort the elements in ascending order.

[·      ]{style="FONT-FAMILY: Symbol"}BASC -- Sort the elements in ascending order by breaking the Hierarchy.

[·      ]{style="FONT-FAMILY: Symbol"}DESC -- Sort the elements in Descending order.

[·      ]{style="FONT-FAMILY: Symbol"}BDESC -- Sort the elements in Descending order by breaking the Hierarchy.

The following report will illustrate the creation of Sort element**:   **

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                     |
| [SortElement]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ sortElement = [new]{style="COLOR: blue"} [SortElement]{style="COLOR: #2b91af"}([AxisPosition]{style="COLOR: #2b91af"}.Categorical, [SortOrder]{style="COLOR: #2b91af"}.BDESC, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                     |
| [sortElement.Element.UniqueName = [\"\[Measures\].\[Internet Sales Amount\]\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sortElement [As]{style="COLOR: blue"} SortElement = [New]{style="COLOR: blue"} SortElement(AxisPosition.Categorical, SortOrder.BDESC, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                 |
| [sortElement.Element.UniqueName = [\"\[Measures\].\[Internet Sales Amount\]\"]{style="COLOR: #c00000"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
