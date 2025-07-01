::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3871e1e5-7a4d-46c4-8cda-e54f7d4ab515){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=24de80d8-8a8c-444b-91ec-a1671c7fd227){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Windows](ms-xhelp:///?Id=af2b5ead-c104-4cdd-b5e2-2b2aee61afe3){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4c7c53bf-fd09-4600-aaf4-4f09cc0f9359){.d2h_breadcrumbsNormal}
:::

## SummaryType {#summarytype style="tab-stops: 0pt"}

SummaryType determines the type of field summary such as count, sum, average, etc. It is an enumerator that should be defined in the *PivotComputationInfo* class. It contains the following types for performing calculations.

Table 8: Summary Type

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
