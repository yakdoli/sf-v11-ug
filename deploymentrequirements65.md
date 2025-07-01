::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=0360e53a-142d-4aef-b552-6ee95ac32a97){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=d5a72d16-1052-4348-a81d-cd8dd8766afc){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Gauge]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=9d3a2ca7-bcf4-4ed9-8bd2-31949b9ef371){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Procedures](ms-xhelp:///?Id=0360e53a-142d-4aef-b552-6ee95ac32a97){.d2h_breadcrumbsNormal}
:::

### Deployment Requirements {#deployment-requirements style="TEXT-ALIGN: justify; tab-stops: 0pt"}

This section provides information and instructions for deploying ASP.NET Mobile MVC applications that use Essential Gauge Mobile MVC. 

**[Marking the Application Directory ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**

The directory where the project files are usually saved, must be marked as an **Application** in the IIS.

**[Referencing Syncfusion Assemblies]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**

The Syncfusion assemblies can either be deployed in the server\'s GAC (Global Assembly Cache), or in the Application\'s bin folder.

**[General Instructions]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**

**[Data Files]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**

If you have XML, .mdb or other data files, ensure that they have sufficient security permissions. The **Authenticated Users** should have access to the files and the directory to give the ASP.NET code enough permission to open the file at runtime. 

**[Deploying in Medium Trust or Partial Trust Scenarios ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}**

There are two scenarios in which the Syncfusion assemblies can be deployed:

1.   Syncfusion Assemblies in the GAC (Global Assembly Cache) and Application running in medium trust\
- This means the Syncfusion assemblies are running in full trust which is explained in the Default Deployment Pattern. This scenario is fully supported and there are no additional steps necessary.

2.   Syncfusion Assemblies in the application bin folder and Application running in medium trust\
- This means both the Syncfusion assemblies and the application code are running in partial trust which is explained in Fast Deployment Pattern. In this case, the control's **DeprecateFunctionalityToRunInPartialTrust** property should be turned on for the control to work properly. This will also mean that some features might not be available. See control\'s documentation for more info.

[]{#related-topics}
::::
