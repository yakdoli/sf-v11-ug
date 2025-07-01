::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3536d6a2-18cc-45ee-af6d-81a609437a10){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=48e2812b-21c2-4339-b01c-589afdcff88a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=3536d6a2-18cc-45ee-af6d-81a609437a10){.d2h_breadcrumbsNormal}
:::

## Deployment Requirements {#deployment-requirements style="tab-stops: 0pt"}

[This section provides information and instructions for deploying ASP.NET MVC applications that use Essential Diagram for MVC.]{style="COLOR: black"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

Marking the Application Directory 

The appropriate directory where the project file is usually saved must be marked as an application in IIS.

Referencing Syncfusion Assemblies 

The Syncfusion assemblies can either be deployed in the server\'s GAC (Global Assembly Cache) or deployed in the Application\'s **bin** folder.

[]{style="COLOR: black; FONT-WEIGHT: normal"} 

General Instructions

Data Files[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

If you have XML, .mdb, or other data files, ensure that they have sufficient security permissions. The **Authenticated Users** should have access to the files and the directory to give the ASP.NET code enough permission to open the file at run time.

Supporting Netscape/Firefox/Mozilla

Ensure that the **machine.config**\'s (of the deployed system) **\<browsercaps\>** section includes appropriate entries for Mozilla, and so on. The default entries consider these browsers as **downlevel** and hence will not render Syncfusion and your controls properly.

Deploying in Medium Trust or Partial Trust Scenarios

There are two such scenarios in which Syncfusion assemblies might be deployed.

1.   Syncfusion assemblies in the GAC (Global Assembly Cache) and the application running in medium trust.

This means the Syncfusion assemblies are running in full trust which is explained in Default Deployment Pattern. This scenario is fully supported and there are no additional steps necessary.

2.   Syncfusion assemblies in the application **bin** folder and the application running in medium trust.

This means both the Syncfusion assemblies and the application code are running in partial trust which is explained in Fast Deployment Pattern. In this case, the control's **DeprecateFunctionalityToRunInPartialTrust** property should be turned on for the control to work properly. This will also mean some features might not be available. See the control\'s documentation for more information.

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Default Deployment Pattern](ms-xhelp:///?Id=48e2812b-21c2-4339-b01c-589afdcff88a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Fast Deployment Pattern](ms-xhelp:///?Id=7b56246a-1b73-4fe8-b044-ed0cb09eb47a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DLL](ms-xhelp:///?Id=45d8c0ab-32c8-44d7-8061-137f361be147){style="TEXT-DECORATION: none"}
::::
