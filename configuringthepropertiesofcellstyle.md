::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f2627f60-a829-4b4c-8f3d-56303e32a662){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4aa387a2-02f4-434b-8f14-4a27c3724757){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Silverlight](ms-xhelp:///?Id=c006b39c-6aa2-4637-b7de-3e7b6cb3f9f9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=6e49680f-da51-4b1f-9043-47e40b9c0684){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid Styling](ms-xhelp:///?Id=3d3dd525-ece1-4957-bd0f-875dcb535d68){.d2h_breadcrumbsNormal}
:::

### Configuring the properties of Cell Style {#configuring-the-properties-of-cell-style style="tab-stops: 0pt"}

The following properties of the Grid cell can be customized, so that the grid appears in a custom style rather than the default style.

Table 7: Properties of the Grid cell

 

::: {align="center"}
+---------------+-----------------------------------------------------+-------------+------------------+-----------------+
|               |                                                     |             |                  |                 |
|               |                                                     |             |                  |                 |
| Property Name | Description                                         | Type        | Value it Accepts | Reference Links |
+---------------+-----------------------------------------------------+-------------+------------------+-----------------+
| Background    | Gets or sets the Background color of the Grid cell. | Brush       | \-               | \-              |
+---------------+-----------------------------------------------------+-------------+------------------+-----------------+
| FontFamily    | Gets or sets the Font family of the Grid cell.      | FontFamily  | \-               | \-              |
+---------------+-----------------------------------------------------+-------------+------------------+-----------------+
| FontSize      | Gets or sets the Font size of the Grid cell.        | int         | \-               | \-              |
+---------------+-----------------------------------------------------+-------------+------------------+-----------------+
| FontWeight    | Gets or sets the Font weight of the Grid cell.      | FontWeight  | \-               | \-              |
+---------------+-----------------------------------------------------+-------------+------------------+-----------------+
| Foreground    | Gets or sets the Foreground color of the Grid cell. | Brush       | \-               | \-              |
+---------------+-----------------------------------------------------+-------------+------------------+-----------------+
:::

 

The Column, Row, Summary, and Value cells of Grid can be formatted independently by using the following properties:

[·      ]{style="FONT-FAMILY: Symbol"}ColumnHeaderStyle

[·      ]{style="FONT-FAMILY: Symbol"}RowHeaderStyle

[·      ]{style="FONT-FAMILY: Symbol"}SummaryColumnStyle

[·      ]{style="FONT-FAMILY: Symbol"}SummaryRowStyle

[·      ]{style="FONT-FAMILY: Symbol"}ValueCellsStyle

 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                        |
| [            [// Specifying the Background color for Grid column header]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                                                        |
| [            [this]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.Background = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.FromRgb(175, 209, 255));]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                                        |
| [            [// Specifying the Background color for Grid row header]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                                        |
| [            [this]{style="COLOR: blue"}.OlapGrid1.RowHeaderCellStyle.Background = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.FromRgb(175, 209, 255));]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                        |
| [            [// Specifying the Background color for Grid summary cell]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                                        |
| [            [this]{style="COLOR: blue"}.OlapGrid1.SummaryColumnStyle.Background = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.FromRgb(206, 225, 248)); ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                                |
| [            [\' Specifying the Background color for Grid column header]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                |
| [            [Me]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.Background = [New]{style="COLOR: blue"} SolidColorBrush(Color.FromRgb(175, 209, 255))]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                |
| [            [\' Specifying the Background color for Grid row header]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                |
| [            [Me]{style="COLOR: blue"}.OlapGrid1.RowHeaderCellStyle.Background = [New]{style="COLOR: blue"} SolidColorBrush(Color.FromRgb(175, 209, 255))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [            [\' Specifying the Background color for Grid summary cell]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                |
| [            [Me]{style="COLOR: blue"}.OlapGrid1.SummaryColumnStyle.Background = [New]{style="COLOR: blue"} SolidColorBrush(Color.FromRgb(206, 225, 248))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

 

Sample Location

A sample demo is available at the following location:

..\\Syncfusion\\EssentialStudio\\\<Versionnumber\>\\BI\\Silverlight\\Syncfusion.OlapGrid.Silverlight.Samples\\Syncfusion.OlapGrid.Silverlight.Samples\\Samples\\ExportDemo

 

[]{#related-topics}
:::::
