::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=400a544d-f0e6-4cd4-9a67-76ca6e33d3fc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b7af1912-6c70-4b79-b800-87ee36f3988e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=695ababb-5473-474b-af2e-63a4a8d37003){.d2h_breadcrumbsNormal}
:::

## [Deployment Requirements]{#_Ref316471117} {#deployment-requirements style="tab-stops: 0pt"}

This section provides information and instructions for deploying ASP.NET applications that use the ChartAdv control.

**Marking the Application Directory**

The appropriate directory usually where the **.aspx** file is saved must be marked as an Application in IIS.

**Referencing Syncfusion Assemblies**

The Syncfusion assemblies can either be deployed in the server\'s GAC (Global Assembly Cache) or deployed in the application\'s **bin** folder.

**a) Default Deployment Pattern**

Our installation installs our assemblies in the GAC in your development machine. So, when you drag and drop the chart control into your form, the assembly references in your application will be set up such that the Syncfusion assemblies will have to be manually deployed in the GAC or in the application bin folder in your target machine.

On drag and drop, one or more of the following **Register** tags will be added to the .aspx:

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: maroon"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Chart.Web, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                             |
| [Namespace]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.ChartAdv\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [TagPrefix]{style="COLOR: red"}[=\"syncfusion\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[![Description: http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/ImagesExt/image9_1.png](ImagesExt/image113_0.png){border="0"}]{style="FONT-SIZE: 9pt"}**[Note: X.X.X.X in the code above corresponds to the correct version number of the Essential Studio version that you are currently using.]{style="FONT-SIZE: 9pt"}***

***[![Description: http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/ImagesExt/image9_1.png](ImagesExt/image113_0.png){border="0"}]{style="FONT-SIZE: 9pt"}**[Note: The TagPrefix for Chart.Web Assembly is changed to Syncfusion.]{style="FONT-SIZE: 9pt"}***

And your app\'s **web.config** file will include references to a list of Syncfusion assemblies that you will be linking to as follows.

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[configuration]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[system.web]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[compilation]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[assemblies]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[add]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[assembly]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[Syncfusion.Chart.Web, Version=X.X.X.X, Culture=neutral, PublicKeyToken=3D67ED1F87D44C89]{style="COLOR: blue"}\"[/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[add]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[assembly]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"[Syncfusion.Core, Version=X.X.X.X, Culture=neutral, PublicKeyToken=632609B4D040F6B4]{style="COLOR: blue"}\"[/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[assemblies]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[compilation]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\... ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[system.web]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[configuration]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

***[![Description: http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/ImagesExt/image9_1.png](ImagesExt/image113_0.png){border="0"}]{style="FONT-SIZE: 9pt"}**[Note: X.X.X.X in the above code corresponds to the correct version number of the Essential Studio version that you are currently using.]{style="FONT-SIZE: 9pt"}***

Also, no DLLs will be copied over to your application\'s **bin** folder.

Now when it\'s time to deploy your application, there is an additional step you need to perform. You have to ensure that the above referenced assemblies (in your **web.config** files) are either present in the GAC or in the application\'s **bin** folder in the deployed server.

The above referenced assemblies can be found in our installation usually in the following path:

\"\[System Drive\]:\\Program Files\\Syncfusion\\Essential Studio\\\<version number \>\\PrecompiledAssemblies\\2.0\".

**b) Alternate Fast Deployment**

Alternatively, you can delete the Syncfusion assembly GAC entries in your development machine. Then, when you drag and drop the Syncfusion controls on to your form in the designer, the referenced assemblies will be copied over to the **bin** folder and the following entries will be added to your .aspx file:

  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Register]{style="COLOR: maroon"} [Assembly]{style="COLOR: red"}[=\"Syncfusion.Chart.Web\"]{style="COLOR: blue"} [Namespace]{style="COLOR: red"}[=\"Syncfusion.Web.UI.WebControls.ChartAdv\"]{style="COLOR: blue"} [TagPrefix]{style="COLOR: red"}[=\"syncfusion\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}
  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

***[![Description: http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/ImagesExt/image9_1.png](ImagesExt/image113_0.png){border="0"}]{style="FONT-SIZE: 9pt"}**[Note: X.X.X.X in the above code corresponds to the correct version number of the Essential Studio version that you are currently using.]{style="FONT-SIZE: 9pt"}***

With this setup you can deploy your application as is, using the VS.NET deployment tools, as the necessary DLLs are already copied over to the **bin** folder.

**Data Files**

If you have XML, .mdb, or other data files, ensure that they have sufficient security permissions. The authenticated users should have access to the files and the directory to give the ASP.NET code enough permission to open the file at run time.

**Supporting Netscape/Firefox/Mozilla**

Ensure that the **machine.config**\'s (of the deployed system) **\<browsercaps\>** section includes appropriate entries for Mozilla, etc. The default entries deem these browsers as **downlevel** and hence will not render Syncfusion and your controls properly. You can get the appropriate entries here.

**Deploying in Medium Trust or Partial Trust Scenarios**

There are two such scenarios in which Syncfusion assemblies might be deployed.

1\. Syncfusion assemblies in the GAC (Global Assembly Cache) and application running in medium trust: This means the Syncfusion assemblies are running in full trust. This scenario is fully supported and there are no additional steps necessary.

2\. Syncfusion assemblies in the application **bin** folder and application running in medium trust:

This means both the Syncfusion assemblies and the application code are running in partial trust. In this case, the control's **DeprecateFunctionalityToRunInPartialTrust** property should be turned on for the control to work properly. This will also mean some features might not be available. See the control's documentation for more info.

[]{#p8}[[![Description: http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/button.gif](ImagesExt/image113_11.gif){border="0" width="17" height="12"}]{style="TEXT-DECORATION: none; text-underline: none"}](http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/Documents/231dlls.htm)[2.3.1 DLLs]{style="COLOR: blue"}

[[![Description: http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/button.gif](ImagesExt/image113_11.gif){border="0" width="17" height="12"}]{style="TEXT-DECORATION: none; text-underline: none"}](http://help.syncfusion.com/ug_94/User%20Interface/ASP.NET/Chart/Documents/232toolboxentries.htm)[2.3.2 Toolbox Entries]{style="COLOR: blue"}

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}DLLs](ms-xhelp:///?Id=b7af1912-6c70-4b79-b800-87ee36f3988e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Toolbox Entries](ms-xhelp:///?Id=699bd512-f912-439c-819b-b513ce02bee9){style="TEXT-DECORATION: none"}
::::
