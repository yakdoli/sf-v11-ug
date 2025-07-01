::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f3245b6b-c5e0-4262-83e6-16be11111c8d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f9ad93f1-7519-441e-b379-8851a5c7b22a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=f3245b6b-c5e0-4262-83e6-16be11111c8d){.d2h_breadcrumbsNormal}
:::

## Deployment Requirements {#deployment-requirements style="tab-stops: 0pt"}

This section provides information and instructions for deploying ASP.NET MVC applications that use Essential Grid MVC.

 

Marking the Application Directory[]{style="FONT-FAMILY: 'Verdana','sans-serif'"}

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

The appropriate directory usually where the project file is saved, must be marked as an **Application** in IIS.

 

Referencing Syncfusion Assemblies[]{style="FONT-FAMILY: 'Verdana','sans-serif'"}

 

The Syncfusion assemblies can either be deployed in the server\'s Global Assembly Cache (GAC) or deployed in the Application\'s bin folder.

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

General Instructions

Data Files[]{style="FONT-FAMILY: 'Verdana','sans-serif'"}

 

If you have XML, .mdb or other data files, ensure that they have sufficient security permissions. The **Authenticated Users** should have access to the files and the directory to give the ASP.NET code enough permission to open the file at runtime.

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

Supporting Netscape / FireFox / Mozilla

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

Ensure that the machine.config\'s (of the deployed system) \<browsercaps\> section includes appropriate entries for Mozilla, and so on. The default entries consider these browsers as **downlevel** and hence will not render Syncfusion and your controls properly.

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

Deploying in Medium Trust or Partial Trust Scenarios

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

There are two such scenarios in which Syncfusion assemblies might be deployed.

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

1.   Syncfusion Assemblies in the GAC  and Application running in medium trust.

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

[       - ]{style="FONT-FAMILY: 'Arial','sans-serif'"}[This means the Syncfusion assemblies are running in full trust, which is explained in ]{.BodyText1Char}[Default Deployment Pattern]{.UGHyperlink}[. This scenario is fully supported and there are no additional steps necessary]{.BodyText1Char}[.]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

2.   Syncfusion assemblies in the application bin folder and applications running in medium trust.

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

       - This means both the Syncfusion assemblies and the application code are running in partial trust, which is explained in [Fast Deployment Pattern]{.UGHyperlink}. In this case, the control's **DeprecateFunctionalityToRunInPartialTrust** property should be turned on for the control to work properly. This will also mean some features might not be available. See control\'s documentation for more info.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{#_Default_Deployment_Pattern}Default Deployment Pattern

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Follow the steps given below to deploy the application in the development server by referencing the dll in GAC.

1.   Web.config file should be configured according to the referenced dlls. For more information on the web.config file configuration,  refer to the following link.

[Configuring Web.Config file]{.UGHyperlink}  []{.UGHyperlink}

2.   Now, when it\'s time to deploy your application, there is an additional step you need to perform. You have to ensure that the above referenced assemblies (in your web.config files) are present in the GAC.

[]{#_Fast_Deployment_Pattern}**[]{style="FONT-FAMILY: 'Arial','sans-serif'"}** 

Fast Deployment Pattern

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Follow the steps given below to deploy the application in the development server by referencing the dll in application\'s bin folder.

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

1.   Delete the Syncfusion assembly GAC entries in your development machine. The referenced assemblies will be copied over to the bin folder.

2.   Web.config file should be configured according to the referenced dlls. For more information on the web.config file configuration,  refer to the following link.

[Configuring Web.Config file]{.UGHyperlink}[  ]{.UGHyperlink}

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image69_5.jpg){border="0"}Note: If you do not want to delete Syncfusion assembly GAC entries, then in Web.config file, remove the Culture, Version and PublicKeyToken attributes used in all [\<]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[assemblies]{style="FONT-FAMILY: Consolas; COLOR: #a31515; FONT-SIZE: 9.5pt"}[\>,\<]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[httpHandlers]{style="FONT-FAMILY: Consolas; COLOR: #a31515; FONT-SIZE: 9.5pt"}[\>]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"} and [\<]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[handlers]{style="FONT-FAMILY: Consolas; COLOR: #a31515; FONT-SIZE: 9.5pt"}[\> ]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}nodes.
:::

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}DLL](ms-xhelp:///?Id=f9ad93f1-7519-441e-b379-8851a5c7b22a){style="TEXT-DECORATION: none"}
:::::
