::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=02fb5cf2-ff1f-4894-93d4-72da3f44dde2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a7351a41-8f0a-414a-9995-97c49acc54ab){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET MVC](ms-xhelp:///?Id=32b055b8-3bdf-473c-bb73-f99a534ce79c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=e4dfef6a-1b95-482e-9e23-753e22591eb9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Drill-Up/Down](ms-xhelp:///?Id=85dce3d6-e642-46e0-bfdd-af9c135acc2a){.d2h_breadcrumbsNormal}
:::

### Adding Drill Up-Down to an Application {#adding-drill-up-down-to-an-application style="tab-stops: 0pt"}

 

This can be enabled by setting the following properties to OlapReport

 

For Drill Member

 

+---------------------------------------------------------------------------------+
| **[\[CS\]]{style="FONT-FAMILY: 'Courier New'"}**                                |
|                                                                                 |
| [report.DrillType = DrillType.DrillMember;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                          |
+---------------------------------------------------------------------------------+

 

For Drill Position

[]{style="FONT-WEIGHT: normal"} 

+-----------------------------------------------------------------------------------+
| **[\[CS\]]{style="FONT-FAMILY: 'Courier New'"}**                                  |
|                                                                                   |
| [report.DrillType = DrillType.DrillPosition;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                            |
+-----------------------------------------------------------------------------------+

 

Samples Link

A sample demo is available at the following location:

[]{#_Toolbar}***..\\Syncfusion\\EssentialStudio\\\<Version Number\>\\MVC\\OlapGrid.Mvc\\Samples\\3.5\\***

 

[]{#related-topics}
::::
