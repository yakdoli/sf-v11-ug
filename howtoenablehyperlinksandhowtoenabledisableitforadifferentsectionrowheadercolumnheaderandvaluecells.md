::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=16e9331e-70d0-4678-8f0c-171403c7a68b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=5367c752-7be7-43d5-bf4c-4f65e82ae515){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Grid]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Frequently asked questions](ms-xhelp:///?Id=345d79d3-3141-4925-a4ce-32673da65509){.d2h_breadcrumbsNormal}
:::

## How to enable hyper-links and how to enable/disable it for a different section (row header, column header and value cells)? {#how-to-enable-hyper-links-and-how-to-enabledisable-it-for-a-different-section-row-header-column-header-and-value-cells style="tab-stops: 0pt"}

Hyperlinks can be enabled by the following property of OlapGrid:

+--------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                 |
|                                                                                                        |
|                                                                                                        |
|                                                                                                        |
| [// To Enable Hyperlink for Column Header]{style="COLOR: green"} []{style="COLOR: blue"}               |
|                                                                                                        |
| [this]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.IsHyperlinkCell = [true]{style="COLOR: blue"}; |
|                                                                                                        |
| [// To Enable Hyperlink for Row Header]{style="COLOR: green"}                                          |
|                                                                                                        |
| [this]{style="COLOR: blue"}.OlapGrid1.RowHeaderStyle.IsHyperlinkCell = [true]{style="COLOR: blue"};    |
|                                                                                                        |
| [// To Enable Hyperlink for Value Cell]{style="COLOR: green"}                                          |
|                                                                                                        |
| [this]{style="COLOR: blue"}.OlapGrid1.ValueCellStyle.IsHyperlinkCell = [true]{style="COLOR: blue"};    |
|                                                                                                        |
|                                                                                                        |
+--------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

+-----------------------------------------------------------------------------------------------------+
| \[VB\]                                                                                              |
|                                                                                                     |
|                                                                                                     |
|                                                                                                     |
| [\' To Enable Hyperlink for Column Header]{style="COLOR: green"}                                    |
|                                                                                                     |
| [Me]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.IsHyperlinkCell = [True]{style="COLOR: blue"} |
|                                                                                                     |
| [\' To Enable Hyperlink for Row Header]{style="COLOR: green"}                                       |
|                                                                                                     |
| [Me]{style="COLOR: blue"}.OlapGrid1.RowHeaderStyle.IsHyperlinkCell = [True]{style="COLOR: blue"}    |
|                                                                                                     |
| [\' To Enable Hyperlink for Value Cell]{style="COLOR: green"}                                       |
|                                                                                                     |
| [Me]{style="COLOR: blue"}.OlapGrid1.ValueCellStyle.IsHyperlinkCell = [True]{style="COLOR: blue"}    |
|                                                                                                     |
|                                                                                                     |
+-----------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

Hyperlink can be disabled by setting the following property of OlapGrid to false

+---------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                  |
|                                                                                                         |
|                                                                                                         |
|                                                                                                         |
| [// To Disable Hyperlink for Column Header]{style="COLOR: green"} []{style="COLOR: blue"}               |
|                                                                                                         |
| [this]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.IsHyperlinkCell = [false]{style="COLOR: blue"}; |
|                                                                                                         |
| [// To Disable Hyperlink for Row Header]{style="COLOR: green"}                                          |
|                                                                                                         |
| [this]{style="COLOR: blue"}.OlapGrid1.RowHeaderStyle.IsHyperlinkCell = [false]{style="COLOR: blue"};    |
|                                                                                                         |
| [// To Disable Hyperlink for Value Cell]{style="COLOR: green"}                                          |
|                                                                                                         |
| [this]{style="COLOR: blue"}.OlapGrid1.ValueCellStyle.IsHyperlinkCell = [false]{style="COLOR: blue"};    |
|                                                                                                         |
|                                                                                                         |
+---------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

+------------------------------------------------------------------------------------------------------+
| \[VB\]                                                                                               |
|                                                                                                      |
|                                                                                                      |
|                                                                                                      |
| [\' To Disable Hyperlink for Column Header]{style="COLOR: green"}                                    |
|                                                                                                      |
| [Me]{style="COLOR: blue"}.OlapGrid1.ColumnHeaderStyle.IsHyperlinkCell = [False]{style="COLOR: blue"} |
|                                                                                                      |
| [\' To Disable Hyperlink for Row Header]{style="COLOR: green"}                                       |
|                                                                                                      |
| [Me]{style="COLOR: blue"}.OlapGrid1.RowHeaderStyle.IsHyperlinkCell = [False]{style="COLOR: blue"}    |
|                                                                                                      |
| [\' To Disable Hyperlink for Value Cell]{style="COLOR: green"}                                       |
|                                                                                                      |
| [Me]{style="COLOR: blue"}.OlapGrid1.ValueCellStyle.IsHyperlinkCell = [False]{style="COLOR: blue"}    |
|                                                                                                      |
|                                                                                                      |
+------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

[]{#related-topics}
::::
