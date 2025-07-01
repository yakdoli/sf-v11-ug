::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=ab48dd48-3e01-4a6f-8e51-7a180265b43f){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e0eb7590-2586-4e93-9581-a4ff58acfcc4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=75b194b1-a824-4764-885e-7bf61f97f614){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Procedures](ms-xhelp:///?Id=322ba94f-f180-4243-82d0-e2818b9ddbbb){.d2h_breadcrumbsNormal}
:::

### Default Deployment Pattern {#default-deployment-pattern style="tab-stops: 0pt"}

Follow the steps below to deploy the application in the development server by referencing the DLL in the GAC.

[1.   The **Web.config** file should be configured according to the referenced DLLs. For more information on the **Web.config** file configuration please refer to the following link:]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}

[[Configuring Web.Config file]{.ughyperlink}](http://help.syncfusion.com/ug_94/User%20Interface/Mobile%20MVC/Tools/Documents/433addingcodestothew.htm) 

[2.   Now, when it\'s time to deploy your application, there is an additional step you will need to perform\--you will have to ensure that the above referenced assemblies (in your web.config files) are present in the GAC.]{style="FONT-FAMILY: 'Arial','sans-serif'; FONT-SIZE: 10pt"}

[]{#related-topics}
::::
