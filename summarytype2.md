::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=28688f20-e435-43f1-9bf3-37a2fc4c8eab){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=fe252a52-66a8-41b6-8b37-ef28c8bd60f8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pivot Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4ac202a5-4d9d-4bd8-8592-31692c415d53){.d2h_breadcrumbsNormal}
:::

## SummaryType {#summarytype style="tab-stops: 0pt"}

SummaryType determines the type of field summary such as count, sum, average, etc. It is an enumerator that should be defined in the *PivotComputationInfo* class. It contains the following types for performing calculations.

Table 9: Summary Type Table

+-----------------------------------+-------------------------------------------------------------------------------------+
|                                   |                                                                                     |
|                                   |                                                                                     |
| Summary Type                      | Description                                                                         |
+-----------------------------------+-------------------------------------------------------------------------------------+
| DoubleTotalSum                    | Computes the sum of double or integer values.                                       |
+-----------------------------------+-------------------------------------------------------------------------------------+
| DoubleAverage                     | Computes the simple average of double or integer values.                            |
+-----------------------------------+-------------------------------------------------------------------------------------+
| DoubleMaximum                     | Computes the maximum of double or integer values.                                   |
+-----------------------------------+-------------------------------------------------------------------------------------+
| DoubleMinimum                     | Computes the minimum of double or integer values.                                   |
+-----------------------------------+-------------------------------------------------------------------------------------+
| DoubleStandardDeviation           | Computes the standard deviation of double or integer values.                        |
+-----------------------------------+-------------------------------------------------------------------------------------+
| DoubleVariance                    | Computes the variance of double or integer values.                                  |
+-----------------------------------+-------------------------------------------------------------------------------------+
| Count                             | Computes the count of double or integer values.                                     |
+-----------------------------------+-------------------------------------------------------------------------------------+
| DecimalTotalSum                   | Computes the sum of decimal values.                                                 |
+-----------------------------------+-------------------------------------------------------------------------------------+
| IntTotalSum                       | Computes the sum of integer values.                                                 |
+-----------------------------------+-------------------------------------------------------------------------------------+
| Custom                            | Specifies that you are using a custom SummaryBase object to define the calculation. |
+-----------------------------------+-------------------------------------------------------------------------------------+

[]{#related-topics}
::::
