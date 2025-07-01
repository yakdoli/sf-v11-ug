::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2ec95bf8-86f9-44d3-bc6a-7d78ff13ed8d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b52f18e9-c111-4ae0-aa51-a9ce581b3b2a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart Axes](ms-xhelp:///?Id=abd42068-df28-4d00-bb9b-28f0b91b8086){.d2h_breadcrumbsNormal}
:::

### Axis Range and Intervals {#axis-range-and-intervals style="tab-stops: 0pt"}

 

Automatic Range Calculation

The range and intervals for an axis are automatically calculated by the built-in \"nice range calculation engine\", by default. This engine takes the raw data series and converts it to a readable range of numbers in which it will be represented. For example, if the data series has points between the range 1.2 to 3.7, then the engine will create a scale of 0 to 5 for the axis with ten intervals of 0.5 each.

This default behavior is controlled by the ChartAxis.RangeType property, which is set to Auto by default.

 

Specifying Custom Ranges

Sometimes the automatic range generation might not be suitable for you, in which case you can specify a custom range on the axis. You should start by setting the ChartAxis.RangeType property to Set. Then use one of the following properties to specify a custom range:

 

::: {align="center"}
+--------------------+----------------------+------------------------------------+-------------------------------------------------------------------------------------------------------------------------+-------------------------------------------------------------------+------------------------------+
| ChartAxis Property | Applies to RangeType | Applies to ValueType (Depenencies) | Description                                                                                                             | Property Type                                                     | Value it Accepts             |
|                    |                      |                                    |                                                                                                                         |                                                                   |                              |
|                    | (Dependencies)       |                                    |                                                                                                                         |                                                                   |                              |
+--------------------+----------------------+------------------------------------+-------------------------------------------------------------------------------------------------------------------------+-------------------------------------------------------------------+------------------------------+
| Range              | Set                  | Double                             | Specifies the minimum, maximum, and interval for the axis. Use this if the data points are of the double type.          | MinMaxInfo                                                        | A MinMaxInfo object.         |
+--------------------+----------------------+------------------------------------+-------------------------------------------------------------------------------------------------------------------------+-------------------------------------------------------------------+------------------------------+
| DateTimeRange      | Set                  | DateTime                           | Specifies the start and end dates and interval time for the axis. Use this if the data points are of the datetime type. | [ChartDateTimeRange]{style="FONT-FAMILY: 'Calibri','sans-serif'"} | A ChartDateTimeRange object. |
+--------------------+----------------------+------------------------------------+-------------------------------------------------------------------------------------------------------------------------+-------------------------------------------------------------------+------------------------------+
:::

Axis Range and Intervals by using any chart can be created through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Builder

[·      ]{style="FONT-FAMILY: Symbol"}ChartModel

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Builder](ms-xhelp:///?Id=0613a279-ec59-42a6-b785-d7110242b65c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ChartModel](ms-xhelp:///?Id=c0bd0abb-429e-4f0c-b6a8-d6a5651306a7){style="TEXT-DECORATION: none"}
:::::
