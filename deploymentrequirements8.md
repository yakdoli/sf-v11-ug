::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e0d8eb50-bc9c-49ef-9156-be9160532ba2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=7531480f-c4ae-47a4-94ae-080666cf1692){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=e0d8eb50-bc9c-49ef-9156-be9160532ba2){.d2h_breadcrumbsNormal}
:::

## Deployment Requirements {#deployment-requirements style="tab-stops: 0pt"}

This section provides information and instructions for deploying ASP.NET MVC applications that use Essential Grid for MVC.

 

Marking the Application Directory

[]{style="FONT-SIZE: 11pt"} 

The appropriate directory usually where the project file is saved must be marked as an **Application** in IIS.

 

Referencing Syncfusion Assemblies

 

The Syncfusion assemblies can be deployed in either the server\'s GAC (Global Assembly Cache) or the application\'s **Bin** folder.

 

General Instructions

Data Files

 

If you have XML, .mdb, or other data files, ensure that they have sufficient security permissions. The **Authenticated Users** should have access to the files and the directory to give the ASP.NET code enough permission to open the file at run time.

[]{style="FONT-SIZE: 11pt"} 

Supporting Netscape/Firefox/Mozilla

[]{style="FONT-SIZE: 11pt"} 

Ensure that the Machine.config\'s (of the deployed system) \<browserCaps\> section includes appropriate entries for Mozilla, and so on. The default entries consider these browsers as **downlevel** and hence will not render Syncfusion and your controls properly.

[]{style="FONT-SIZE: 11pt"} 

Deploying in Medium Trust or Partial Trust Scenarios

[]{style="FONT-SIZE: 11pt"} 

There are 2 such scenarios in which Syncfusion assemblies might be deployed.

[]{style="FONT-SIZE: 11pt"} 

1.   Syncfusion assemblies in the GAC (Global Assembly Cache) and application running in medium trust.

 

This means the Syncfusion assemblies are running in full trust which is explained in [[Default Deployment Pattern]{style="COLOR: blue"}]{.underline}. This scenario is fully supported and there are no additional steps necessary.[]{style="FONT-SIZE: 11pt"}

[]{style="FONT-SIZE: 11pt"} 

2.   Syncfusion assemblies in the application **Bin** folder and application running in medium trust.

 

This means both the Syncfusion assemblies and the application code are running in partial trust which is explained in [[Fast Deployment Pattern]{style="COLOR: blue"}]{.underline}. In this case, the control's **DeprecateFunctionalityToRunInPartialTrust** property should be turned on for the control to work properly. This also means some features might not be available. See the control\'s documentation for more info.[]{style="FONT-SIZE: 11pt"}

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Default Deployment Pattern](ms-xhelp:///?Id=7531480f-c4ae-47a4-94ae-080666cf1692){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Fast Deployment Pattern](ms-xhelp:///?Id=b5048643-c9f2-44a4-839a-9a0c2f01462a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DLL](ms-xhelp:///?Id=4750f8ea-6a3e-4a61-84cd-f366af140751){style="TEXT-DECORATION: none"}
::::
