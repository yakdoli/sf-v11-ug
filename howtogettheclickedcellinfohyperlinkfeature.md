::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=cb06a679-080f-4b78-9532-71ce227144de){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2e60d24e-d227-4a73-aa4a-0777312ba649){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Grid]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Frequently asked questions](ms-xhelp:///?Id=345d79d3-3141-4925-a4ce-32673da65509){.d2h_breadcrumbsNormal}
:::

## How to get the clicked cell info (Hyperlink feature)? {#how-to-get-the-clicked-cell-info-hyperlink-feature style="tab-stops: 0pt"}

The Hyperlink Click event can be tagged by the following way:

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                                                                                               |
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
|                                                                                                                                                                                      |
| [// Tag Hyperlink Cell Click Event]{style="COLOR: green"}                                                                                                                            |
|                                                                                                                                                                                      |
| [this]{style="COLOR: blue"}.OlapGrid1.LinkClick += [new]{style="COLOR: blue"} Syncfusion.Windows.Grid.Olap.[LinkLabelClickEventHander]{style="COLOR: #2b91af"}(OlapGrid1_LinkClick); |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[VB\]                                                                                                                                                                           |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
| [\' Tag Hyperlink Cell Click Event]{style="COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                  |
| [Me]{style="COLOR: blue"}.OlapGrid1.LinkClick += [New]{style="COLOR: blue"} Syncfusion.Windows.Grid.Olap.[LinkLabelClickEventHander]{style="COLOR: black"}(OlapGrid1_LinkClick); |
|                                                                                                                                                                                  |
|                                                                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

The HyperlinkCellClickArg event will return the clicked Cell Descriptor.

+---------------------------------------------------------------------------------------------------------------------------------------------------+
| \[C#\]                                                                                                                                            |
|                                                                                                                                                   |
|                                                                                                                                                   |
|                                                                                                                                                   |
| [void]{style="COLOR: blue"} OlapGrid1_HyperlinkCellClick([object]{style="COLOR: blue"} sender, [HyperlinkCellClickArg]{style="COLOR: #2b91af"} e) |
|                                                                                                                                                   |
| {                                                                                                                                                 |
|                                                                                                                                                   |
|                                                                                                                                                   |
|                                                                                                                                                   |
| }                                                                                                                                                 |
|                                                                                                                                                   |
|                                                                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[VB\]\                                                                                                                                                                                                                                                            |
| \                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                    |
| [Private]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} OlapGrid1_HyperlinkCellClick([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"}[Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} HyperlinkCellClickArg) |
|                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                    |
| [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                    |
| []{style="COLOR: blue"}                                                                                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::
