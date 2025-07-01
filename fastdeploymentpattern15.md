::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5356da8b-5e48-43dd-a4b5-315fbd0e6987){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8870cf9f-be0f-4faa-8110-fc4dd58a79b8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=cd89e30d-2315-407f-8b24-e1aa09c0d493){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Requirements](ms-xhelp:///?Id=748ebe78-e241-4cc9-8dc7-8377086be7d6){.d2h_breadcrumbsNormal}
:::

### Fast Deployment Pattern {#fast-deployment-pattern style="tab-stops: 0pt"}

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

Follow the steps below to deploy the application in development server by referencing the dll in application\'s bin folder.

 

1.   Delete the Syncfusion assembly GAC entries in your development machine. The referenced assemblies will be copied over to the bin folder.

2.  Web.config file should be configured according to the referenced dlls. For more information on the web.config file configuration please refer the following link.

[[Configuring Web.Config file]{style="COLOR: blue"}]{.underline}  [[]{style="COLOR: blue"}]{.underline}

***[![](ImagesExt/image56_5.jpg){border="0"}]{style="FONT-SIZE: 9pt"}**[Note: If you do not want to delete Syncfusion assembly GAC entries, then in Web.config file, please remove the Culture, Version and PublicKeyToken attributes used in all ]{style="LAYOUT-GRID-MODE: line; FONT-SIZE: 9pt"}**[\<]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}**[assemblies]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: #a31515; FONT-SIZE: 9.5pt"}**[\>,\<]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}**[httpHandlers]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: #a31515; FONT-SIZE: 9.5pt"}**[\>]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}**[ and ]{style="LAYOUT-GRID-MODE: line; FONT-SIZE: 9pt"}**[\<]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}**[handlers]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: #a31515; FONT-SIZE: 9.5pt"}**[\> ]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}**[nodes.]{style="LAYOUT-GRID-MODE: line; FONT-SIZE: 9pt"}***

***[]{style="LAYOUT-GRID-MODE: line; FONT-SIZE: 9pt"}*** 

[]{#related-topics}
::::
