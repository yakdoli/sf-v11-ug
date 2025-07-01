::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d242b2cf-659c-4d79-bb1c-67165b8468d1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=00544b08-24a0-47f7-93f0-f9500f6db382){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential BI Gauge]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=b21891c2-ee4b-41e6-a92d-29a3ab4cd8c5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Appearance](ms-xhelp:///?Id=d242b2cf-659c-4d79-bb1c-67165b8468d1){.d2h_breadcrumbsNormal}
:::

### How to set gauge radius? {#how-to-set-gauge-radius style="tab-stops: 0pt"}

The *OLAP Gauge* control provides support to adjust its radius. This is achieved by assigning a proper value to the radius property of *OLAP Gauge*.

 

+-----------------------------------------------------------------------+
| **\[C#\]**                                                            |
|                                                                       |
|                                                                       |
|                                                                       |
| [this]{style="COLOR: blue"}.olapGauge1.Radius = 100;                  |
|                                                                       |
| [this]{style="COLOR: blue"}.olapGauge1.DataBind();                    |
+-----------------------------------------------------------------------+

 

+-----------------------------------------------------------------------+
| **\[VB\]**                                                            |
|                                                                       |
|                                                                       |
|                                                                       |
| [Me]{style="COLOR: blue"}.olapGauge1.Radius = 100                     |
|                                                                       |
| [Me]{style="COLOR: blue"}.olapGauge1.DataBind()                       |
+-----------------------------------------------------------------------+

 

![Description: C:\\Users\\Hari\\Pictures\\OlapGauge\\Radius.png](ImagesExt/image43_18.jpg){border="0"}

Figure 15: Setting radius for OLAP Gauge

***[]{style="FONT-FAMILY: 'Cambria','serif'; COLOR: black"}***  

Sample Location

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}**  

A sample demo is available at the following location:

**..\\Syncfusion\\EssentialStudio\\\<Version Number\>\\BI\\WPF\\OlapGauge.WPF\\Samples\\Gauge Customization\\Customization Demo\\**

[]{#related-topics}
::::
