::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6277486f-1e84-4cd9-b0c6-ad20e278cf72){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=26b6dc70-7ca4-458b-89bf-66c1a18829ae){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=67645206-a62c-4d69-9ad4-52c865a681a5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Chart Legend with Legend Items](ms-xhelp:///?Id=6277486f-1e84-4cd9-b0c6-ad20e278cf72){.d2h_breadcrumbsNormal}
:::

### ChartLegend {#chartlegend style="tab-stops: 0pt"}

The legend is represented by the ChartLegend type.

**Default Legend**

By default, a custom ChartLegend instance gets added to the legends list in the control. You can access this default legend.

**Legend Look and Feel**

The following table lists some common properties you could use to customize the overall legend appearance:

::: {align="center"}
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
| ChartLegend Property | Description                                                                                                              | Type of Property | Value it accepts   | Dependencies                            |
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
| Visible              | Gets or sets if the Legend is visible or not.                                                                            | bool             | True               | NA                                      |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | False              |                                         |
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
| ItemPadding          | Gets or sets the padding for every item in the legend.                                                                   | double           | Any double value   | Visible---                              |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  |                    | Only applies if Chart legend is visible |
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
| TextColor            | Gets or sets the forecolor of te item                                                                                    | Color            | Color.AliceBlue    | Visible---                              |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | .                  | Only applies if Chart legend is visible |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | Color.Black        |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | .                  |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | Color.White        |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | .                  |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | .                  |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | Color.YellowGreen  |                                         |
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
| Shape                | Gets or sets the shape of the legend.                                                                                    | LegendShape      | LegendShape.Circle | Visible---                              |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | LegendShape.Cross  | Only applies if Chart legend is visible |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | .                  |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | .                  |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | .                  |                                         |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  | LegendShape.Wedge  |                                         |
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
| ShapeSize            | Gets or sets the size of every legend item.                                                                              | Size             | SizeObject         | Visible---                              |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  |                    | Only applies if Chart legend is visible |
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
| Style                | Gets or sets the style of the legend item, which include the border, interior, line cap, line join, opacity, and shadow. | Style            | StyleObject        | Visible---                              |
|                      |                                                                                                                          |                  |                    |                                         |
|                      |                                                                                                                          |                  |                    | Only applies if Chart legend is visible |
+----------------------+--------------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------------+
:::

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Legend Positioning

The legend positioning can be affected in the following ways:

::: {align="center"}
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
| ChartModel      | Description                                                                                                              | Type of Property | Value it accepts       | Dependencies                            |
|                 |                                                                                                                          |                  |                        |                                         |
| Property        |                                                                                                                          |                  |                        |                                         |
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
| LegendAlignment | Gets or the alignment of the legend in the chart.                                                                        | StringAlignment  | StringAlignment.Far    | NA                                      |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | StringAlignment.Center |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | StringAlignment.Near   |                                         |
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
| LegendPosition  | Gets or sets the padding for every item in the legend.                                                                   | double           | Any double value       | Visible---                              |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  |                        | Only applies if Chart legend is visible |
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
| TextColor       | Gets or sets the forecolor of te item                                                                                    | Color            | Color.AliceBlue        | Visible---                              |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | .                      | Only applies if Chart legend is visible |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | Color.Black            |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | .                      |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | Color.White            |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | .                      |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | .                      |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | Color.YellowGreen      |                                         |
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
| Shape           | Gets or sets the shape of the legend.                                                                                    | LegendShape      | LegendShape.Circle     | Visible---                              |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | LegendShape.Cross      | Only applies if Chart legend is visible |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | .                      |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | .                      |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | .                      |                                         |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  | LegendShape.Wedge      |                                         |
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
| ShapeSize       | Gets or sets the size of every legend item.                                                                              | Size             | SizeObject             | Visible---                              |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  |                        | Only applies if Chart legend is visible |
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
| Style           | Gets or sets the style of the legend item, which include the border, interior, line cap, line join, opacity, and shadow. | Style            | StyleObject            | Visible---                              |
|                 |                                                                                                                          |                  |                        |                                         |
|                 |                                                                                                                          |                  |                        | Only applies if Chart legend is visible |
+-----------------+--------------------------------------------------------------------------------------------------------------------------+------------------+------------------------+-----------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Chart with legend can be created through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Builder

[·      ]{style="FONT-FAMILY: Symbol"}ChartModel

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=ae0fa4a9-ed0a-4172-acda-56934ff8c9bf){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using ChartModel](ms-xhelp:///?Id=ba33ca3f-7f0b-4c16-879e-7d8c42ab5281){style="TEXT-DECORATION: none"}
::::::
