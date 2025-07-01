::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=0c8d44e0-b37f-40bf-975d-60a57fb9d396){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4cb90960-3adc-4360-a1e2-18358c1738f2){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Grid]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=ea758680-939d-4d65-8abe-8c3be198af29){.d2h_breadcrumbsNormal}
:::

## Freeze Headers {#freeze-headers style="tab-stops: 0pt"}

OlapGrid for WPF provides built-in support to freeze the Column and Row Headers. This is achieved by setting the **FreezeHeaders** property of **OlapGrid** to true. This feature also enables scrolling through the value cells.

 

+------------------------------------------------------------------------------------+
| \[C#\]                                                                             |
|                                                                                    |
|                                                                                    |
|                                                                                    |
| [// To Freeze Grid Headers]{style="COLOR: green"}                                  |
|                                                                                    |
| [this]{style="COLOR: blue"}.OlapGrid1.FreezeHeaders = [true]{style="COLOR: blue"}; |
|                                                                                    |
|                                                                                    |
+------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

+---------------------------------------------------------------------------------+
| \[VB\]                                                                          |
|                                                                                 |
|                                                                                 |
|                                                                                 |
| [\' To Freeze Grid Headers]{style="COLOR: green"}                               |
|                                                                                 |
| [Me]{style="COLOR: blue"}.OlapGrid1.FreezeHeaders = [True]{style="COLOR: blue"} |
|                                                                                 |
|                                                                                 |
+---------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 11pt"} 

![](ImagesExt/image44_33.jpg){border="0"}

Figure 30: OlapGrid with Freeze Headers

[]{style="FONT-SIZE: 11pt"} 

Sample Location

A sample demo is available at the following location:

**..\\Syncfusion\\EssentialStudio\\\<Versionnumber\>\\BI\\WPF\\OlapGrid.WPF\\Samples\\Appearance\\Frozen Header Demo**

[]{#related-topics}
::::
