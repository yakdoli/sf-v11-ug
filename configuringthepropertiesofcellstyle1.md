::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4b8b69b6-064e-4af5-bfd4-f48b5b689cd8){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=41939395-c927-4e81-b042-23129c45aa91){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Grid]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=ea758680-939d-4d65-8abe-8c3be198af29){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Grid Styling](ms-xhelp:///?Id=3c17a3a2-5d3d-4690-b7aa-d989ebd2f03d){.d2h_breadcrumbsNormal}
:::

### Configuring the properties of Cell Style {#configuring-the-properties-of-cell-style style="tab-stops: 0pt"}

The following properties of Grid cell can be customized, so that the grid appears in a custom style rather than the default one:

+---------------+-------------------------------------------------+-------------+------------------+-----------------+
|               |                                                 |             |                  |                 |
|               |                                                 |             |                  |                 |
| Property Name | Description                                     | Type        | Value it Accepts | Reference Links |
+---------------+-------------------------------------------------+-------------+------------------+-----------------+
| Background    | Gets or sets the Background color of Grid cell. | Brush       | \-               | \-              |
+---------------+-------------------------------------------------+-------------+------------------+-----------------+
| FontFamily    | Gets or sets the Font family of Grid cell.      | FontFamily  | \-               | \-              |
+---------------+-------------------------------------------------+-------------+------------------+-----------------+
| FontSize      | Gets or sets the Font size of Grid cell.        | int         | \-               | \-              |
+---------------+-------------------------------------------------+-------------+------------------+-----------------+
| FontWeight    | Gets or sets the Font weigh of Grid cell.       | FontWeight  | \-               | \-              |
+---------------+-------------------------------------------------+-------------+------------------+-----------------+
| Foreground    | Gets or sets the Foreground color of Grid cell. | Brush       | \-               | \-              |
+---------------+-------------------------------------------------+-------------+------------------+-----------------+

 

The Column, Row, Summary and Value cells of Grid can be formatted independently using the following properties:

[·      ]{style="FONT-FAMILY: Symbol"}ColumnHeaderStyle

[·      ]{style="FONT-FAMILY: Symbol"}RowHeaderStyle

[·      ]{style="FONT-FAMILY: Symbol"}SummaryColumnStyle

[·      ]{style="FONT-FAMILY: Symbol"}SummaryRowStyle

[·      ]{style="FONT-FAMILY: Symbol"}ValueCellsStyle

 

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                                                                                                                         |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
|                    [// Specifying the Background color for Grid column header]{style="COLOR: green"}                                                                                                           |
|                                                                                                                                                                                                                |
|             [this]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.Background = [new]{style="COLOR: blue"}[SolidColorBrush]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.FromRgb(175, 209, 255));  |
|                                                                                                                                                                                                                |
|             [// Specifying the Background color for Grid row header]{style="COLOR: green"}                                                                                                                     |
|                                                                                                                                                                                                                |
|             [this]{style="COLOR: blue"}.OlapGrid1.RowHeaderCellStyle.Background = [new]{style="COLOR: blue"}[SolidColorBrush]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.FromRgb(175, 209, 255)); |
|                                                                                                                                                                                                                |
|             [// Specifying the Background color for Grid summary cell]{style="COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                                |
|             [this]{style="COLOR: blue"}.OlapGrid1.SummaryColumnStyle.Background = [new]{style="COLOR: blue"}[SolidColorBrush]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.FromRgb(206, 225, 248)); |
|                                                                                                                                                                                                                |
|                                                                                                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[VB\]                                                                                                                                                          |
|                                                                                                                                                                 |
|                                                                                                                                                                 |
|                                                                                                                                                                 |
|                    [\' Specifying the Background color for Grid column header]{style="COLOR: green"}                                                            |
|                                                                                                                                                                 |
|                    [Me]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.Background = [New]{style="COLOR: blue"} SolidColorBrush(Color.FromRgb(175, 209, 255))  |
|                                                                                                                                                                 |
|                    [\' Specifying the Background color for Grid row header]{style="COLOR: green"}                                                               |
|                                                                                                                                                                 |
|                    [Me]{style="COLOR: blue"}.OlapGrid1.RowHeaderCellStyle.Background = [New]{style="COLOR: blue"} SolidColorBrush(Color.FromRgb(175, 209, 255)) |
|                                                                                                                                                                 |
|                    [\' Specifying the Background color for Grid summary cell]{style="COLOR: green"}                                                             |
|                                                                                                                                                                 |
|                    [Me]{style="COLOR: blue"}.OlapGrid1.SummaryColumnStyle.Background = [New]{style="COLOR: blue"} SolidColorBrush(Color.FromRgb(206, 225, 248)) |
|                                                                                                                                                                 |
|                                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The **Value cell** text alignment can be changed using the following property of OlapGrid,

+----------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                               |
|                                                                                                                      |
|                                                                                                                      |
|                                                                                                                      |
| [// Specifying the Value Cell TextAlignment as Center]{style="COLOR: green"}                                         |
|                                                                                                                      |
| [this]{style="COLOR: blue"}.OlapGrid1.ValueCellTextAlignment = [HorizontalAlignment]{style="COLOR: #2b91af"}.Center; |
|                                                                                                                      |
|                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------+

 

Sample Location

A sample demo is available at the following location:

**..\\Syncfusion\\EssentialStudio\\\<Versionnumber\>\\BI\\WPF\\OlapGrid.WPF\\Samples\\Exporting\\Exporting Grid Demo**

 

[]{#related-topics}
::::
