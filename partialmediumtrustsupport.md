::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c8ff0dc6-09bd-40c7-8f87-ea0c57e06811){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=dadccc39-0052-4215-aa1f-056dbb5ba56e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI ASP.NET MVC](ms-xhelp:///?Id=32b055b8-3bdf-473c-bb73-f99a534ce79c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=1f20b70b-bb6c-4ae2-811f-5b58f30e2205){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Procedures](ms-xhelp:///?Id=5efeead4-321d-4bea-884e-4d7da1027b51){.d2h_breadcrumbsNormal}
:::

### Partial/Medium Trust Support {#partialmedium-trust-support style="tab-stops: 0pt"}

There are two such scenarios in which Syncfusion assemblies might be deployed.

[]{style="FONT-SIZE: 11pt"} 

1.   Syncfusion Assemblies in the Global Assembly Cache (GAC) and Application running in medium trust.

[]{style="FONT-SIZE: 11pt"} 

This means the Syncfusion assemblies are running in full trust, which is explained in [[Default Deployment Pattern]{.UGHyperlink}](ms-xhelp:///?Id=f9b39af3-c1bb-4508-971f-bf44e88c3c14). This scenario is fully supported and there are no additional steps necessary.

[]{style="FONT-SIZE: 11pt"} 

2.   Syncfusion Assemblies are in the application bin folder and the application runs in medium trust.

[]{style="FONT-SIZE: 11pt"} 

This means both the Syncfusion assemblies and the application code are running in partial trust, which is explained in [[Fast Deployment Pattern]{.UGHyperlink}](ms-xhelp:///?Id=c8ff0dc6-09bd-40c7-8f87-ea0c57e06811). In this case, the control's **DeprecateFunctionalityToRunInPartialTrust** property should be turned on for the control to work properly. This will also mean some features might not be available. See control\'s documentation for more information.

[]{style="COLOR: #c00000"} 

[]{#related-topics}
::::
