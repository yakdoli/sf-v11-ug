::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=da36b9c7-3e53-42d5-b02c-dbead57fef4f){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=efdefd7d-b2b3-4820-b8f4-06098b422219){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Chart Legend with Legend Items](ms-xhelp:///?Id=da36b9c7-3e53-42d5-b02c-dbead57fef4f){.d2h_breadcrumbsNormal}
:::

### ChartLegend {#chartlegend style="tab-stops: 0pt"}

The legend is represented by the ChartLegend type.

**Default Legend**

By default, a custom ChartLegend instance gets added to the legends list in the control. You can access this default legend.

**Legend Look and Feel**

The following table lists some common properties you could use to customize the overall legend appearance:

::: {align="center"}
  ----------------------- ---------------------------------------------------------------------------------------------------------------------------------
  ChartLegend Property    Description
  BackColor               Gets or sets the background color of the legend. The default value is Transparent.
  Border                  Gets or sets the border style of the legend. ShowBorder should be set to true.
  ShowBorder              Specifies whether a border should be drawn. By default it is set to false.
  Font                    Specifies the font that is to be used for the text rendered in the legend items. The default font style is Verdana, 8, Regular.
  BackInterior            Sets the interior appearance for the legend. This overrides the BackColor property.
  BackgroundImage         Sets the background image for the legend. This setting overrides the BackInterior property settings.
  BackgroundImageLayout   Sets the layout for the background image.
  ----------------------- ---------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Legend Positioning

The legend positioning can be affected in the following ways:

 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| ChartLegend Property              | Description                                                                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| Position                          | Specifies the position relative to the chart for which to render the legend.                                                       |
|                                   |                                                                                                                                    |
|                                   | **Top** - Above the chart.                                                                                                         |
|                                   |                                                                                                                                    |
|                                   | **Left** - Left of the chart.                                                                                                      |
|                                   |                                                                                                                                    |
|                                   | **Right** - Right of the chart.                                                                                                    |
|                                   |                                                                                                                                    |
|                                   | **Bottom** - Below the chart.                                                                                                      |
|                                   |                                                                                                                                    |
|                                   | **Floating** - Will not be docked to any specific location. This is the default setting.                                           |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| LegendAlignment                   | When docked to a side, this property specifies how the legend should be aligned with respect to the chart boundaries.              |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| LegendPlacement                   | Specifies the placement of a legend in a chart. It can be placed inside or outside the ChartArea by using the ChartPlacement enum. |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| FloatingAutoSize                  | Specifies whether to determine the size automatically or not, while floating.                                                      |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| OnlyColumnsForFloating            | The legend items will be displayed vertically in columns when floating.                                                            |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| RowsCount                         | Specifies the number of rows in which the legend items should be rendered.                                                         |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
| ColumnsCount                      | Specifies the number of columns in which the legend items should be rendered.                                                      |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{#related-topics}
::::::
