::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=895ee437-1738-49ea-b2a5-247d41ce7a5b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6bda3b8d-c98b-4433-b83d-6a45492638f9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=895ee437-1738-49ea-b2a5-247d41ce7a5b){.d2h_breadcrumbsNormal}
:::

## Chart Types {#chart-types style="tab-stops: 0pt"}

Essential Chart includes a comprehensive set of 8 basic chart types for all your business needs. Each one is highly and easily configurable with built-in support for creating stunning visual effects.

Chart types are specified on each chart series by using the **Type** property. All the chart types are required to have at least one X and one Y value. Certain chart types need more than one Y value.

The following table narrates the minimum and maximum number of series and number of Y values required by each type of chart supported by Essential Chart.

::: {align="center"}
  Chart Type    Minimum Number of Series   Maximum Number of Series   Number of Y Values Required
  ------------- -------------------------- -------------------------- -----------------------------
  Area          1                          Unlimited                  1
  Column        1                          Unlimited                  1
  Combination   2                          Unlimited                  1
  Line          1                          Unlimited                  1
  Pie           1                          1                          1
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Series Properties

+-------------+-------------------------------------+---------------+-----------------------+-------------+
| Name        | Description                         | Property Type | Value it accepts      | Dependency  |
+-------------+-------------------------------------+---------------+-----------------------+-------------+
| Type        | Gets or sets the chart series type. | SeriesType    | SeriesType.Line       | NA          |
|             |                                     |               |                       |             |
|             |                                     |               | SeriesType.Spline     |             |
|             |                                     |               |                       |             |
|             |                                     |               | SeriesType.StepLine   |             |
|             |                                     |               |                       |             |
|             |                                     |               | SeriesType.Area       |             |
|             |                                     |               |                       |             |
|             |                                     |               | SeriesType.StepArea   |             |
|             |                                     |               |                       |             |
|             |                                     |               | SeriesType.SplineArea |             |
|             |                                     |               |                       |             |
|             |                                     |               | SeriesType.Pie        |             |
|             |                                     |               |                       |             |
|             |                                     |               | SeriesType.Column     |             |
+-------------+-------------------------------------+---------------+-----------------------+-------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Line Charts](ms-xhelp:///?Id=6bda3b8d-c98b-4433-b83d-6a45492638f9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Area Charts](ms-xhelp:///?Id=b508a304-1159-4327-b142-4de2e6c9f621){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Column Charts](ms-xhelp:///?Id=95ed9aad-d105-4c4b-882a-982e47c9465b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Pie Chart](ms-xhelp:///?Id=23b692d5-2296-43cb-996c-90347ca72756){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Combination Chart](ms-xhelp:///?Id=1e37851a-5ced-427b-82a4-bbc104f0e869){style="TEXT-DECORATION: none"}
:::::
